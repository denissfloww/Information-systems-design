using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using Orders.Domain.Models;
using Excel = Microsoft.Office.Interop.Excel;
using OrdersClient.Controllers;

namespace OrdersClient.Forms
{
    public partial class OrdersForm : MetroForm
    {
        public int UserId { get; set; }
        delegate void InvokeDelegate();


        public Dictionary<string, string> Filter;
        public OrdersForm(int userId)
        {
            InitializeComponent();
            UserId = userId;
            Filter = new Dictionary<string, string>();
        }

        private void OrdersForm_Load(object sender, EventArgs e)
        {
            if (!UserController.CanEdit(UserId))
            {
                btnAdd.Enabled = false;
                btnDelete.Enabled = false;
                btnAdd.Visible = false;
                btnDelete.Visible = false;
            }
            OrderGridFill();
        } 

        private void OrdersForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var addForm = new AddOrderForm(UserId, this);
            addForm.ShowDialog(this);                  
        }

        private void OpenOrderForm()
        {
            if (ordersGrid.SelectedRows.Count == 0)
            {
                MetroMessageBox.Show(this, "Не выбран заказ-наряд", "Первое предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                return;
            }

            int orderId;
            if (int.TryParse(ordersGrid.SelectedRows[0].Cells[0].Value.ToString(), out orderId))
            {
                var orderForm = new OrderForm(UserId, orderId);
                orderForm.ShowDialog();
                OrderGridFill();
            }
            else
            {
                MetroMessageBox.Show(this, "Совсем тук-тук", "Второе предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
        }

        private void btnOpenOrder_Click(object sender, EventArgs e)
        {
            OpenOrderForm();
        }

        private void ordersGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            OpenOrderForm();
        }

        public void OrderGridFill()
        {
            BeginInvoke(new MethodInvoker(delegate
            {
                ordersGrid.Rows.Clear();
                var orders = OrderController.GetOrders(UserId, Filter);
                foreach (var order in orders)
                {
                    ordersGrid.Rows.Add(order.Id,
                        order.Plans.Place,
                        order.CatchGoal,
                        order.DateCreate,
                        order.Users.Organizations.Name);
                }
            }));
        }

        private async void btnFilter_Click(object sender, EventArgs e)
        {
            var filter = new FilterForm(this);
            filter.ShowDialog();
            metroProgressSpinner1.Visible = true;
            await Task.Run(() => OrderGridFill());
            metroProgressSpinner1.Visible = false;
        }

        private async void btnDeleteAllFilters_Click(object sender, EventArgs e)
        {
            metroProgressSpinner1.Visible = true;
            Filter.Clear();
            await Task.Run(() => OrderGridFill());
            metroProgressSpinner1.Visible = false;

        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (CheckOneRowSelected())
            {
                var id = (int)ordersGrid.SelectedRows[0].Cells[0].Value;
                ordersGrid.Rows.Remove(ordersGrid.SelectedRows[0]);
                await Task.Run(() => OrderController.DeleteOrder(UserId, id));
                await Task.Run(() => OrderGridFill());
            }           
        }

        private void btnExportSelect_Click(object sender, EventArgs e)
        {
 
        }

        private async void btnExportAll_Click(object sender, EventArgs e)
        {
            var orderIds = new List<int>();
            for (int i = 0; i < ordersGrid.Rows.Count; i++)
                orderIds.Add(int.Parse(ordersGrid.Rows[i].Cells[0].Value.ToString()));


            metroProgressSpinner1.Visible = true;
            var excelApp = await Task.Run(() => OrderController.ExportOrders(orderIds));
            metroProgressSpinner1.Visible = false;

            excelApp.Visible = true;
            excelApp.UserControl = true;

        }

        private bool CheckOneRowSelected()
        {
            if (ordersGrid.SelectedRows.Count > 1)
            {
                MetroMessageBox.Show(this, "Выберите одну строку", "Ошибка выбор строки", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                return false;
            }
            return true;
        }
    }
}
