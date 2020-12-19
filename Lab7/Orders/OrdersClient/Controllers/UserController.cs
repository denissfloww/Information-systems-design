using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orders.Domain.Services;

namespace OrdersClient.Controllers
{
    public class UserController
    {
        public static int Auth(string username, string password)
        {
            return UserService.Auth(username, password);
        }
    }
}
