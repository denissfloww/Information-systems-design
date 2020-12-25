using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using Orders.Domain.Models;
using Excel = Microsoft.Office.Interop.Excel;
using OrdersClient.Controllers;

namespace OrdersClient.Forms
{
    public partial class OrdersForm : MetroForm
    {
        public int UserId { get; set; }

        public Dictionary<string, string> Filter;
        public OrdersForm(int userId)
        {
            InitializeComponent();
            UserId = userId;
            Filter= new Dictionary<string, string>();
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

        private void btnOpenOrder_Click(object sender, EventArgs e)
        {
            var order = new OrderForm();
            order.ShowDialog();
            OrdersForm_Load(null, null);
        }

        private void OrdersForm_Load(object sender, EventArgs e)
        {
            OrderGridFill();
        }

        public void OrderGridFill()
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
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            var filter = new FilterForm(this);
            filter.ShowDialog();
            OrdersForm_Load(null,null);
        }

        private void btnDeleteAllFilters_Click(object sender, EventArgs e)
        {
            Filter.Clear();
            OrdersForm_Load(null,null);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            OrderController.DeleteOrder(UserId, (int)ordersGrid.CurrentRow.Cells[0].Value);
            OrderGridFill();
        }

        private void btnExportSelect_Click(object sender, EventArgs e)
        {
 
        }

        private void btnExportAll_Click(object sender, EventArgs e)
        {
            var orderIds = new List<int>();
            for (int i = 0; i < ordersGrid.Rows.Count; i++)
                orderIds.Add(int.Parse(ordersGrid.Rows[i].Cells[0].Value.ToString()));

            var excelApp = new Excel.Application();

            //Excel.Application excelApp = new Excel.Application();
            Excel.Workbook workBook;
            Excel.Worksheet workSheet = OrderController.ExportOrders(orderIds);
            workBook = excelApp.Workbooks.Add();
            workSheet = (Excel.Worksheet)workBook.Worksheets.get_Item(1);

            excelApp.Visible = true;
            excelApp.UserControl = true;
        }
    }
}
