using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrdersClient.Controllers;

namespace OrdersClient.Forms
{
    public partial class AddOrderForm : MetroForm
    {
        private int PlanId { get; set; }
        public int UserId { get; set; }

        OrdersForm parent = null;

        public AddOrderForm(int userId, OrdersForm parent)
        {
            UserId = userId;
            this.parent = parent;
            InitializeComponent();
        }

        private void AddOrderForm_Load(object sender, EventArgs e)
        {
           
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            OrderController.CreateOrder(UserId, PlanId, tbCatch.Text);
            parent.OrderGridFill();
            this.Close();
        }

        private void btnPlan_Click(object sender, EventArgs e)
        {
            var planForm = new PlanForm(UserId, GetPlanId);
            planForm.ShowDialog();
        }

        private void GetPlanId(int planId)
        {
            PlanId = planId;
            DateAndPlaceTbFill();
        }

        private void DateAndPlaceTbFill()
        {
            lblDate.Visible = true;
            lblPlace.Visible = true;
            tbPlace.Visible = true;
            dtDate.Visible = true;
            this.Height = 375;
            var currPlanItem = PlanController.GetPlanInfo().FirstOrDefault(p => p.Id == PlanId);
            tbPlace.Text = currPlanItem.Place;
            dtDate.Value = currPlanItem.Date;
        }
    }
}
