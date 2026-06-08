using System.Collections.Generic;
using Quản_lý_thuê_xe_máy.Entity;
using Quản_lý_thuê_xe_máy.DAL.Interfaces;

namespace Quản_lý_thuê_xe_máy.DAL
{
    public class XeDAL : IXeDAL
    {
        public List<Xe> GetAll()
        {
            return new List<Xe>()
            {
                new Xe()
                {
                    MaXe = "XM001",
                    TenXe = "Honda Vision",
                    BienSo = "75A-12345",
                    LoaiXe = "Xe ga",
                    GiaThue = 120000,
                    TrangThai = "Sẵn sàng"
                },

                new Xe()
                {
                    MaXe = "XM002",
                    TenXe = "Honda Air Blade",
                    BienSo = "75A-88888",
                    LoaiXe = "Xe ga",
                    GiaThue = 180000,
                    TrangThai = "Đang thuê"
                },

                new Xe()
                {
                    MaXe = "XM003",
                    TenXe = "Yamaha Exciter 155",
                    BienSo = "75A-99999",
                    LoaiXe = "Xe côn",
                    GiaThue = 250000,
                    TrangThai = "Bảo trì"
                }
            };
        }
    }
}