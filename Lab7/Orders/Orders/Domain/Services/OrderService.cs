using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.Pkcs;
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
            Dictionary<string, string> filter, 
            Tuple<string, bool> sort = null, 
            int page = 1)
        {
            var orgId = UserService.GetUser(userId).OrganizationId;
            var seeOrganizationAll = UserService.SeeOrganizationAll(userId);
            #region Trash

            //GenericRepository<Order>.Get().Where(o=>filter.ContainsValue(o.CatchGoal)&&filter.ContainsValue(o.Id.ToString())&&);
            // var loh= GenericRepository<Order>.Get().AsQueryable().ToDictionary(o => o.CatchGoal);
            //GenericRepository<Order>.Get().Where(o => o.Users.OrganizationId == orgId || o.Plans.ClientId == orgId).ToList(); 

            #endregion

            if (!filter.ContainsKey("Пользователь"))
                    filter.Add("Пользователь", orgId.ToString());


            var orders = GenericRepository<Order>.Get();
            if (filter.Count == 0) return orders;
            foreach (var row in filter)
            {
                switch (row.Key)
                {
                    case "Пользователь" when seeOrganizationAll:
                        continue;
                    case "Пользователь":
                        orders = orders
                            .Where(o => o.Users.OrganizationId.ToString() == row.Value)
                            .ToList();
                        break;
                    case "Номер":
                        orders = orders
                            .Where(o => o.Id.ToString() == row.Value )
                            .ToList();
                        break;
                    case "Место":
                        orders = orders
                            .Where( o => o.Plans.Place==row.Value)
                            .ToList();
                        break;
                    case "Цель":
                        orders = orders
                            .Where(o => o.CatchGoal == row.Value)
                            .ToList();
                        break;
                    case "Дата создания":
                        orders = orders
                            .Where(o => o.DateCreate.Value.ToString("dd.MM.yyyy") == row.Value)
                            .ToList();
                        break;
                    case "Исполнитель":
                        orders = orders
                            .Where(o => o.Users.Organizations.Name == row.Value || o.Users.OrganizationId.ToString() == row.Value)
                            .ToList();
                        break;
                }
            }
            return orders;
        }

        public static List<Order> GetOrders(List<int> orderIds) 
            => GenericRepository<Order>.Get().Where(o => orderIds.Contains(o.Id)).ToList();

        public static Order GetOrder(int orderId)
        {
            return GenericRepository<Order>.Get(order => order.Id == orderId).First();
        }

        public static void UpdateOrder(
            int userId,
            int orderId, 
            int planId,
            string catchGoal = null,
            object scan = null)
        {
            if (UserService.CanEdit(userId))
            {
                var order = GenericRepository<Order>.GetById(orderId);
                PlanService.UpdatePlan((int)order.PlanId);
                PlanService.UpdatePlan(planId, orderId);

                order.PlanId = planId;
                if (catchGoal != null) order.CatchGoal = catchGoal;

                FileStream fileScan = scan as FileStream;
                if (fileScan != null)
                {
                    if (!Directory.Exists("scans")) Directory.CreateDirectory("scans");

                    order.Scan = Path.Combine("scans", Path.GetFileName(fileScan.Name));
                    var buffer = new byte[fileScan.Length];
                    fileScan.Read(buffer, 0, buffer.Length);
                    File.WriteAllBytes(order.Scan, buffer);
                    fileScan.Close();
                }
                else
                {
                    order.Scan = null;
                }

                GenericRepository<Order>.Update(order);
            }
        }

        public static void CreateOrder(int userId, int planId, string cathcGoal)
        {
            var order = new Order() { 
                UserId = userId, 
                PlanId = planId,
                CatchGoal = cathcGoal,
                DateCreate = DateTime.Now
            };
            var orderId = GenericRepository<Order>.Create(order);
            PlanService.UpdatePlan(planId, orderId);
        }

        public static void DeleteOrder(int userId, int orderId)
        {
            var order = OrderService.GetOrder(orderId);
            PlanService.UpdatePlan((int)order.PlanId);
            GenericRepository<Order>.Remove(order);
        }
    }
}
