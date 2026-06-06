using System.Collections.Generic;
using System.Linq;
using Quản_lý_thuê_xe_máy.Entity;
using Quản_lý_thuê_xe_máy.DAL.Interfaces;

namespace Quản_lý_thuê_xe_máy.DAL
{
    public class UserDAL : IUserDAL
    {
        public User Login(string username, string password)
        {
            return AppData.Users.FirstOrDefault(x =>
                x.Username == username &&
                x.Password == password);
        }

        public List<User> GetAll()
        {
            return AppData.Users;
        }
    }
}