using System;

namespace Quản_lý_thuê_xe_máy.Entity
{
    public class BaoTri
    {
        public string MaBaoTri { get; set; }

        public string MaXe { get; set; }

        public string LoaiBaoTri { get; set; }

        public DateTime NgayBaoTri { get; set; }

        public string NoiDung { get; set; }

        public decimal ChiPhi { get; set; }

        public string NhaCungCap { get; set; }
    }
}