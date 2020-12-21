using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orders.Domain.Models;
using Orders.Domain.Services;
using Orders.Domain.Repositories;
using Orders.Infrastructure;

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

            Fill(places, dates);
            Console.WriteLine("Готово");
        }

        public static void Fill(string [] places, List<DateTime> dates)
        {
            List<Plan> plan = new List<Plan>();
            foreach(var place in places)
            {
                foreach(var date in dates)
                {
                    GenericRepository<Plan>.Create(new Plan() {
                        Place = place,
                        Date = date,
                        ClientId = 2
                    });
                }
            }
        }
    }
}
