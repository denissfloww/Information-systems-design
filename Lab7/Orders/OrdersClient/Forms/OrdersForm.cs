﻿using System;
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
            ordersGrid.Rows.Clear();
            var orders = OrderController.GetOrders(UserId,Filter);
            foreach(var order in orders)
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
            var filter = new FilterForm(this,OrdersForm_Load);
            filter.ShowDialog();
            OrdersForm_Load(null,null);
        }

        private void btnDeleteAllFilters_Click(object sender, EventArgs e)
        {
            Filter.Clear();
            OrdersForm_Load(null,null);
        }

    }
}
