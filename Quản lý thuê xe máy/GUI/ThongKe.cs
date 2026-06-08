using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Quản_lý_thuê_xe_máy.DAL;
using Quản_lý_thuê_xe_máy.DAL.Interfaces;
using Quản_lý_thuê_xe_máy.Entity;

namespace Quản_lý_thuê_xe_máy.cs
{
    public partial class ThongKe : Form
    {
        private decimal tongDoanhThu = 0;
        private int tongLuotThue = 0;
        private int xeDangThue = 0;

        public ThongKe()
        {
            InitializeComponent();
        }

        private void CapNhatThongKe()
        {
            lblDoanhThu.Text =
                tongDoanhThu.ToString("N0") + " đ";

            lblLuotThue.Text =
                tongLuotThue.ToString();

            lblXeDangThue.Text =
                xeDangThue.ToString();

            lblTongDoanhThu.Text =
                "Tổng doanh thu: "
                + tongDoanhThu.ToString("N0")
                + " VNĐ";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvThongKe.Columns.Clear();

            dgvThongKe.Columns.Add("STT", "STT");
            dgvThongKe.Columns.Add("MaHD", "Mã hóa đơn");
            dgvThongKe.Columns.Add("MaKH", "Mã khách hàng");
            dgvThongKe.Columns.Add("MaXe", "Mã xe");
            dgvThongKe.Columns.Add("TongTien", "Tổng tiền");

            dgvThongKe.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            IHoaDonDAL hoaDonDAL = new HoaDonDAL();

            List<HoaDonEntity> dsHoaDon =
                hoaDonDAL.GetAll();

            dgvThongKe.Rows.Clear();

            int stt = 1;

            foreach (HoaDonEntity hd in dsHoaDon)
            {
                dgvThongKe.Rows.Add(
                    stt++,
                    hd.MaHD,
                    hd.MaKH,
                    hd.MaXe,
                    hd.TongTien.ToString("N0")
                );
            }

            tongDoanhThu =
                dsHoaDon.Sum(x => x.TongTien);

            tongLuotThue =
                dsHoaDon.Count;

            xeDangThue =
                dsHoaDon.Count;

            CapNhatThongKe();
        }

        private void btnDoanhThu_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Doanh thu hiện tại: "
                + tongDoanhThu.ToString("N0")
                + " VNĐ");
        }

        private void btnLuotThue_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Tổng lượt thuê: "
                + tongLuotThue);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Dữ liệu thống kê hiện đang được lấy từ HoaDonDAL.");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblTongDoanhThu_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}