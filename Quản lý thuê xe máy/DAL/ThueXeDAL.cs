using System;
using System.Collections.Generic;
using Quản_lý_thuê_xe_máy.Entity;
using Quản_lý_thuê_xe_máy.DAL.Interfaces;

namespace Quản_lý_thuê_xe_máy.DAL
{
    public class ThueXeDAL : IThueXeDAL
    {
        public List<ThueXe> GetAll()
        {
            return new List<ThueXe>()
            {
                new ThueXe()
                {
                    MaThue = "MT001",
                    MaKH = "KH001",
                    MaXe = "XM001",
                    NgayThue = DateTime.Today,
                    SoNgay = 3,
                    GiaThue = 120000,
                    TienCoc = 200000,
                    TongTien = 360000
                },

                new ThueXe()
                {
                    MaThue = "MT002",
                    MaKH = "KH002",
                    MaXe = "XM002",
                    NgayThue = DateTime.Today,
                    SoNgay = 2,
                    GiaThue = 180000,
                    TienCoc = 300000,
                    TongTien = 360000
                }
            };
        }
    }
}