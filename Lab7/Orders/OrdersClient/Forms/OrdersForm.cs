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

        private void OrdersForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var planForm = new PlanForm(UserId);
            planForm.ShowDialog();
        }

        private void btnOpenOrder_Click(object sender, EventArgs e)
        {
            var order = new OrderForm();
            order.ShowDialog();
        }

        private void OrdersForm_Load(object sender, EventArgs e)
        {
            var orders = OrderController.GetOrders(UserId);
            foreach(var order in orders)
            {
                ordersGrid.Rows.Add(order.Id, 
                    order.Plans.Place, 
                    order.CatchGoal, 
                    order.DateCreate, 
                    order.Users.Organizations.Name);
            }

            var a = 0;
        }
    }
}
