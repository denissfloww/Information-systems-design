using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orders.Domain.Models;
using Orders.Domain.Repositories;

namespace Orders.Domain.Services
{
    public class PlanService
    {
        public static void UpdatePlan(int planId, int? orderId = null)
        {

        }

        public static List<Plan> GetPlanInfo()
        {
            return GenericRepository<Plan>.Get();
        }
    }
}
