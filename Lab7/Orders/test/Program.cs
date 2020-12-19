using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            var places = new[] {"Восточный","Центральный"};
            var dates = new List<DateTime>();
            var year = 2020;
            var month = 12;
            for (var date = new DateTime(year, month, 1); date.Month == month; date = date.AddDays(1))
            {
                dates.Add(date);
            }

            var plans = Fill(places, dates);
            var a = 0;
        }

        public static List<Plan> Fill(string [] places, List<DateTime> dates)
        {
            List<Plan> plan = new List<Plan>();
            foreach(var place in places)
            {
                foreach(var date in dates)
                {
                    plan.Add(new Plan()
                    {
                        Place = place,
                        Date = date,
                        OrgId = 1
                    });
                }
            }

            return plan;
        }
    }

    public class Plan
    {
        public string Place { get; set; }
        public DateTime Date { get; set; }
        public int OrgId { get; set; }
    }
}
