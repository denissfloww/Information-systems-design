﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orders.Domain.Models;

namespace Orders.Domain.Services
{
    public class OrderService
    {
        //TODO: Добавить GetOrders()
        //TODO: Dict это Dictionary типо? Если да то какие у него значения для ключа и значения?

        public static Order GetOrder(int orderId)
        {
            return new Order();
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

        }

        public static void DeleteOrder(int userId, int orderId)
        {

        }
    }
}
