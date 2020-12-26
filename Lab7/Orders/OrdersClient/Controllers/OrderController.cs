using Orders.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orders.Domain.Services;
using Excel = Microsoft.Office.Interop.Excel;
using Word = Microsoft.Office.Interop.Word;

namespace OrdersClient.Controllers
{
    public class OrderController
    {
        //TODO: Добавить GetOrders()
        //TODO: Dict это Dictionary типо? Если да то какие у него значения для ключа и значения?

        public static List<Order> GetOrders(int userId,
            Dictionary<string, string> filter,
            Tuple<string, bool> sort = null,
            int page = 1)
        {
            return OrderService.GetOrders(userId,filter);
        }
    
        public static Order GetOrder(int orderId)
        {
            return OrderService.GetOrder(orderId);
        }

        public static void UpdateOrder(
            int userId,
            int orderId, 
            int planId,
            string catchGoal = null,
            object scan = null)
        {
            OrderService.UpdateOrder(userId, orderId, planId, catchGoal, scan);
        }

        //TODO: Добавить Export методы, определиться с возвращаемым типом

        public static Excel.Application ExportOrders(List<int> orderIds)
            => ExportOrderService.ExportOrders(OrderService.GetOrders(orderIds));

        public static Word.Application ExportOrder(int orderId) 
            => ExportOrderService.ExportOrder(OrderService.GetOrder(orderId));
        


        public static void CreateOrder(int userId, int planId, string cathcGoal)
        {
            OrderService.CreateOrder(userId, planId, cathcGoal);
        }

        public static void DeleteOrder(int userId, int orderId)
        {
            OrderService.DeleteOrder(userId, orderId);
        }
    }
}
