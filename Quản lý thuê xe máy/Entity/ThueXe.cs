using System;

namespace Quản_lý_thuê_xe_máy.Entity
{
    public class ThueXe
    {
        public string MaThue { get; set; }

        public string MaKH { get; set; }

        public string MaXe { get; set; }

        public DateTime NgayThue { get; set; }

        public int SoNgay { get; set; }

        public decimal GiaThue { get; set; }

        public decimal TienCoc { get; set; }

        public decimal TongTien { get; set; }
    }
}