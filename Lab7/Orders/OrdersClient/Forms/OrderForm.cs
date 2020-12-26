using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using Orders.Domain.Models;
using Orders.Domain.Services;
using OrdersClient.Controllers;

namespace OrdersClient.Forms
{
    public partial class OrderForm : MetroForm
    {
        Order order;
        int userId;
        int planId;
        object scan;
        public OrderForm(int userId, int orderId)
        {
            InitializeComponent();

            this.userId = userId;
            this.order = OrderController.GetOrder(orderId);
            this.planId = (int)order.PlanId;

            btnChangePlan.Enabled = btnUpdateOrder.Enabled = UserController.CanEdit(userId);
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            tbNum.Text = order.Id.ToString();
            tbNumMK.Text = order.NumMK.ToString();
            dtMK.Value = order.DateMK;

            // TODO: get plan by planId
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

            tbScan.Text = Path.GetFileName(order.Scan);
            btnScan.Text = string.IsNullOrEmpty(order.Scan) ? "Загрузить скан-образ" : "Удалить скан-образ";
        }

        private void btnUpdateOrder_Click(object sender, EventArgs e)
        {
            Task.Run(() => OrderController.UpdateOrder(userId, order.Id, planId, tbCatchGoal.Text, scan));
            MetroMessageBox.Show(this, "Заказ-наряд обновлён", "Обновление заказ-наряда", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }

        private void btnChangePlan_Click(object sender, EventArgs e)
        {
            var planForm = new PlanForm(userId, id => {
                planId = id;
                Plan plan = PlanController.GetPlanInfo().Where(_plan => _plan.Id == planId).First();
                tbCatchPlace.Text = plan.Place;
                dtCatch.Value = plan.Date;
            });
            planForm.ShowDialog();
        }

        private void btnExportOrder_Click(object sender, EventArgs e)
        {

        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbScan.Text))
            {
                var ofDialog = new OpenFileDialog();
                ofDialog.ShowDialog();
                if (!string.IsNullOrEmpty(ofDialog.FileName) && scan == null)
                {
                    tbScan.Text = ofDialog.SafeFileName;
                    scan = new FileStream(ofDialog.FileName, FileMode.Open);
                }
            }
            else
            {
                ((FileStream)scan).Close();
                scan = null;
                tbScan.Text = "";
            }

            btnScan.Text = scan == null ? "Загрузить скан-образ" : "Удалить скан-образ";
        }

        private void OrderForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (scan != null) ((FileStream)scan).Close();
        }
    }
}
