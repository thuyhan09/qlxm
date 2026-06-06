using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace Quản_lý_thuê_xe_máy
{
    internal class DataStore
    {
    }
    public static class AppData
    {
        public static List<User> Users = new List<User>()
     {
        new User(){ Username="admin", Password="123", Role="Admin"},
        new User(){ Username="nv01", Password="123", Role="Nhân viên"},
        
     };
    }
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }

    }
    public static class Session
    {

        public static string CurrentUser;
        public static string CurrentRole;
    }
}
