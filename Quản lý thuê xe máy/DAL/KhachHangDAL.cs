using System.Collections.Generic;
using Quản_lý_thuê_xe_máy.Entity;
using Quản_lý_thuê_xe_máy.DAL.Interfaces;

namespace Quản_lý_thuê_xe_máy.DAL
{
    public class KhachHangDAL : IKhachHangDAL
    {
        public List<KhachHang> GetAll()
        {
            return new List<KhachHang>()
            {
                new KhachHang()
                {
                    MaKH = "KH001",
                    HoTen = "Nguyễn Văn A",
                    SDT = "0901112222",
                    CCCD = "123456789"
                },

                new KhachHang()
                {
                    MaKH = "KH002",
                    HoTen = "Trần Thị B",
                    SDT = "0987776655",
                    CCCD = "987654321"
                },

                new KhachHang()
                {
                    MaKH = "KH003",
                    HoTen = "Lê Thanh Phương",
                    SDT = "0912345678",
                    CCCD = "456789123"
                }
            };
        }
    }
}