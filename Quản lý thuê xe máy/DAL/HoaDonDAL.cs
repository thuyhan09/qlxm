using System.Collections.Generic;
using Quản_lý_thuê_xe_máy.Entity;
using Quản_lý_thuê_xe_máy.DAL.Interfaces;

namespace Quản_lý_thuê_xe_máy.DAL
{
    public class HoaDonDAL : IHoaDonDAL
    {
        public List<HoaDonEntity> GetAll()
        {
            return new List<HoaDonEntity>()
            {
                new HoaDonEntity()
                {
                    MaHD = "HD001",
                    MaKH = "KH001",
                    MaXe = "XM001",
                    TongTien = 240000
                },

                new HoaDonEntity()
                {
                    MaHD = "HD002",
                    MaKH = "KH002",
                    MaXe = "XM002",
                    TongTien = 360000
                }
            };
        }
    }
}