using System;
using System.Collections.Generic;
using Quản_lý_thuê_xe_máy.Entity;
using Quản_lý_thuê_xe_máy.DAL.Interfaces;

namespace Quản_lý_thuê_xe_máy.DAL
{
    public class BaoTriDAL : IBaoTriDAL
    {
        public List<BaoTri> GetAll()
        {
            return new List<BaoTri>()
            {
                new BaoTri()
                {
                    MaBaoTri = "BT001",
                    MaXe = "XM011",
                    LoaiBaoTri = "Định kỳ",
                    NgayBaoTri = new DateTime(2026, 6, 1),
                    NoiDung = "Thay nhớt, kiểm tra phanh",
                    ChiPhi = 500000,
                    NhaCungCap = "Honda"
                },

                new BaoTri()
                {
                    MaBaoTri = "BT002",
                    MaXe = "XM010",
                    LoaiBaoTri = "Sửa chữa lớn",
                    NgayBaoTri = new DateTime(2026, 5, 15),
                    NoiDung = "Thay lốp",
                    ChiPhi = 1200000,
                    NhaCungCap = "Yamaha"
                },

                new BaoTri()
                {
                    MaBaoTri = "BT003",
                    MaXe = "XM008",
                    LoaiBaoTri = "Định kỳ",
                    NgayBaoTri = new DateTime(2026, 6, 5),
                    NoiDung = "Bảo dưỡng động cơ",
                    ChiPhi = 500000,
                    NhaCungCap = "Honda"
                }
            };
        }
    }
}