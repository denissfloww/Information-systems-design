﻿using Orders.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersClient.Controllers
{
    public class OrderController
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

        //TODO: Добавить Export методы, определиться с возвращаемым типом

        public static void CreateOrder(int userId, int planId, string cathcGoal)
        {

        }

        public static void DeleteOrder(int userId, int orderId)
        {

        }
    }
}