using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orders;
using Orders.Domain.Models;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {           
            Context context = new Context();
            var user = context.Users.FirstOrDefault();
            var a = 0;
        }
    }
}
