using MetroFramework.Forms;
using Orders.Domain.Models;
using OrdersClient.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrdersClient.Forms
{
    public partial class PlanForm : MetroForm
    {
        public int UserId { get; set; }
        public PlanForm(int userId)
        {
            InitializeComponent();
            UserId = userId;
        }


        public void PlanGridFill()
        {
            planGrid.Rows.Clear();
            planGrid.Columns.Clear();
            lblPlan.Text = null;
            List<Plan> planItems = PlanController.GetPlanInfo();
            var allPlaces = planItems.Select(plan => plan.Place).Distinct().ToList();
            var allDates = planItems.Select(plan => plan.Date).Distinct().ToList();
            var currDate = allDates.FirstOrDefault();
            lblPlan.Text = $"План-график на {currDate.ToString("MMM")}. {currDate.Year} года";
            planGrid.Columns.Add("empty", " ");
            foreach (var date in allDates)
            {
                planGrid.Columns.Add(date.Day.ToString(), date.Day.ToString());
            }
            foreach (var place in allPlaces)
            {
                int rowNumber = planGrid.Rows.Add(place);
                foreach (var date in allDates)
                {
                    var currentPlan = planItems.FirstOrDefault(p => p.Place == place && p.Date == date);
                    planGrid.Rows[rowNumber].Cells[date.Day.ToString()].Tag = currentPlan.Id;
                    if (currentPlan.OrderId != null)
                    {
                        planGrid.Rows[rowNumber].Cells[date.Day.ToString()].Value = " ";
                        planGrid.Rows[rowNumber].Cells[date.Day.ToString()].Style.BackColor = Color.Gray;
                        planGrid.Rows[rowNumber].Cells[date.Day.ToString()].Style.ForeColor = Color.Gray;

                    }
                }
            }
        }

        private void PlanForm_Load(object sender, EventArgs e)
        {
            PlanGridFill();
        }

        private void planGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex > 0)
            {
                if (planGrid.CurrentCell.Value == null)
                {
                    int id = (int)planGrid.CurrentCell.Tag;
                    var addForm = new AddOrderForm(id, UserId);
                    addForm.ShowDialog();
                }
            }
        }
    }
}
