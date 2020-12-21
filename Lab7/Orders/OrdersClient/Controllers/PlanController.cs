using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orders.Domain.Models;
using Orders.Domain.Services;

namespace OrdersClient.Controllers
{
    public class PlanController
    {
        public static void UpdatePlan(int planId, int orderId)
        {

        }

        public static List<Plan> GetPlanInfo()
        {
            return PlanService.GetPlanInfo();
        }
    }
}
