using Quản_lý_thuê_xe_máy.Entity;
using System.Collections.Generic;
namespace Quản_lý_thuê_xe_máy.DAL.Interfaces
{
    public interface IUserDAL
    {
        User Login(string username, string password);

        List<User> GetAll();
    }
}