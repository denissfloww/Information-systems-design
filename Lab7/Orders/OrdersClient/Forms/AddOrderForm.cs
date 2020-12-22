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
        public int PlanId { get; set; }
        public int UserId { get; set; }
        public AddOrderForm(int planId, int userId)
        {
            UserId = userId;
            PlanId = planId;
            InitializeComponent();
        }

        private void AddOrderForm_Load(object sender, EventArgs e)
        {
            var currPlanItem = PlanController.GetPlanInfo().FirstOrDefault(p => p.Id == PlanId);
            dtDate.Value = currPlanItem.Date;
            tbPlace.Text = currPlanItem.Place;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            OrderController.CreateOrder(UserId, PlanId, tbCatch.Text);
        }
    }
}
