using System.Collections.Generic;
using Quản_lý_thuê_xe_máy.Entity;

namespace Quản_lý_thuê_xe_máy.DAL.Interfaces
{
    public interface IThueXeDAL
    {
        List<ThueXe> GetAll();
    }
}