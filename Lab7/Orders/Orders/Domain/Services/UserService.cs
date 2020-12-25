using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using Orders.Domain.Repositories;
using Orders.Domain.Models;

namespace Orders.Domain.Services
{
    public class UserService
    {
        public static int Auth(string username, string password)
        {
            var user = GenericRepository<User>.Get(_user => 
                _user.Username == username && 
                _user.Password == password);
            return user.Count != 0 ? user.First().Id : 0;
        }    

        public static User GetUser(int userId)
        {
            return GenericRepository<User>.GetById(userId);
        }

        public static bool CanEdit(int userId)
        {
            var user = GetUser(userId);
            return user.Roles.Id == 1;
        }
    }
}
