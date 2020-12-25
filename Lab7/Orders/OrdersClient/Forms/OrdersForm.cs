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
using OrdersClient.Controllers;

namespace OrdersClient.Forms
{
    public partial class OrdersForm : MetroForm
    {
        public int UserId { get; set; }
        public OrdersForm(int userId)
        {
            InitializeComponent();
            UserId = userId;
        }

        private void OrdersForm_Load(object sender, EventArgs e)
        {
            var orders = OrderController.GetOrders(UserId);
            foreach (var order in orders)
            {
                ordersGrid.Rows.Add(
                    order.Id,
                    order.Plans.Place,
                    order.CatchGoal,
                    order.DateCreate,
                    order.Users.Organizations.Name);
            }
        }

        private void OrdersForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var planForm = new PlanForm(UserId);
            planForm.ShowDialog();
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
                var orderForm = new OrderForm(orderId);
                orderForm.ShowDialog();
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
