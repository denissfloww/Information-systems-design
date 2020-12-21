using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test2
{
    public partial class Form1 : Form
    {
        List<Plan> plans;
        public Form1()
        {
            InitializeComponent();
            var places = new[] { "Восточный", "Центральный", "Заречный" };
            var dates = new List<DateTime>();
            var year = 2021;
            var month = 2;
            for (var date = new DateTime(year, month, 1); date.Month == month; date = date.AddDays(1))
            {
                dates.Add(date);
            }

            plans = Fill(places, dates);
            GridViewFill();
           
        }

        public void GridViewFill()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            var places2 = plans.Select(plan => plan.Place).Distinct().ToList();


            var dates2 = plans.Select(plan => plan.Date).Distinct().ToList();

            dataGridView1.Columns.Add("empty", " ");
            foreach (var date in dates2)
            {
                dataGridView1.Columns.Add(date.Day.ToString(), date.Day.ToString());
                dataGridView1.Columns[date.Day.ToString()].Width = 20;
            }



            foreach (var place in places2)
            {
                int rowNumber = dataGridView1.Rows.Add(place);
                foreach (var date in dates2)
                {
                    var currentPlan = plans.FirstOrDefault(p => p.Place == place && p.Date == date);
                    dataGridView1.Rows[rowNumber].Cells[date.Day.ToString()].Tag = currentPlan.id;
                    if (currentPlan.OrderId != null)
                    {
                        dataGridView1.Rows[rowNumber].Cells[date.Day.ToString()].Value = currentPlan.id;
                    }

                }

            }
        }

        public static List<Plan> Fill(string[] places, List<DateTime> dates)
        {
            List<Plan> plan = new List<Plan>();
            int count = 1;
            foreach (var place in places)
            {
                foreach (var date in dates)
                {
                    plan.Add(new Plan()
                    {
                        id = count,
                        Place = place,
                        Date = date,
                        OrgId = 1
                    });
                    count++;
                }
            }

            return plan;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = (int)dataGridView1.CurrentCell.Tag;
            var currPlan = plans.FirstOrDefault(p => p.id == id);
            currPlan.OrderId = 1;
            GridViewFill();
        }
    }

    public class Plan
    {
        public int id { get; set; }
        public string Place { get; set; }
        public DateTime Date { get; set; }
        public int OrgId { get; set; }

        public int? OrderId { get; set; }
    }
}
