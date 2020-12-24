using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orders.Domain.Models;
using Orders.Domain.Repositories;

namespace Orders.Domain.Services
{
    public class OrderService
    {
        //TODO: Добавить GetOrders()
        //TODO: Dict это Dictionary типо? Если да то какие у него значения для ключа и значения?

        public static List<Order> GetOrders(int userId, 
            Dictionary<string, string> filter = null, 
            Tuple<string, bool> sort = null, 
            int page = 1)
        {
            var orgId = UserService.GetUser(userId).OrganizationId;
            return GenericRepository<Order>.Get().Where(o => o.Users.OrganizationId == orgId || o.Plans.ClientId == orgId).ToList();           
        }

        public static List<Order> GetOrders(List<int> orderIds)
        {
            throw new NotImplementedException();
        }

        public static Order GetOrder(int orderId)
        {
            throw new NotImplementedException();
        }

        public static void UpdateOrder(
            int userId, 
            int orderId, int planId,
            string catchGoal = null, 
            object scan = null)
        {

        }

        public static void CreateOrder(int userId, int planId, string cathcGoal)
        {
            throw new NotImplementedException();
        }

        public static void DeleteOrder(int userId, int orderId)
        {
            throw new NotImplementedException();
        }
    }
}
