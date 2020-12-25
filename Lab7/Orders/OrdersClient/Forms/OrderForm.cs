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
    public partial class OrderForm : MetroForm
    {
        Order order; 
        public OrderForm(int orderId)
        {
            InitializeComponent();

            order = OrderController.GetOrder(orderId);
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            tbNum.Text = order.Id.ToString();
            tbNumMK.Text = order.NumMK.ToString();
            dtMK.Value = order.DateMK;

            tbClientOrg.Text = order.Plans.Organizations.Name;
            tbClintOrgAddress.Text = order.Plans.Organizations.Address;
            tbClinetOrgTel.Text = order.Plans.Organizations.Number;

            tbPerformerOrg.Text = order.Users.Organizations.Name;
            tbPerformerOrgAddress.Text = order.Users.Organizations.Address;
            tbPerformerOrgTel.Text = order.Users.Organizations.Number;

            tbCatchGoal.Text = order.CatchGoal;
            tbCatchPlace.Text = order.Plans.Place;
            dtCatch.Value = order.Plans.Date;
            dtOrderCreated.Value = (DateTime)order.DateCreate;
        }

        private void btnUpdateOrder_Click(object sender, EventArgs e)
        {

        }
    }
}
