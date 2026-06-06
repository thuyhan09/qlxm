using Dangnhap;
using Quản_lý_thuê_xe_máy.cs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quản_lý_thuê_xe_máy
{
    public partial class frmChinh : Form
    {
        public frmChinh()
        {
            InitializeComponent();
        }
        public void OpenForm(Form frm)
        {
            pnlNoiDung.Controls.Clear();

            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;

            pnlNoiDung.Controls.Add(frm);

            frm.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pnlMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblHang_Click(object sender, EventArgs e)
        {

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void btnThueXe_Click(object sender, EventArgs e)
        {
            pnlNoiDung.Controls.Clear();

            Thuexe f = new Thuexe();

            f.TopLevel = false;

            f.FormBorderStyle = FormBorderStyle.None;

            f.Dock = DockStyle.Fill;

            pnlNoiDung.Controls.Add(f);

            f.Show();
        }

        private void frmChinh_Load(object sender, EventArgs e)
        {
            OpenUserControl(new ucDashboard(this));

        }
        private void OpenUserControl(UserControl uc)
        {
            pnlNoiDung.Controls.Clear();

            uc.Dock = DockStyle.Fill;

            pnlNoiDung.Controls.Add(uc);
        }

        private void btnXeMay_Click(object sender, EventArgs e)
        {
            pnlNoiDung.Controls.Clear();

            QuanLyXe frm = new QuanLyXe();

            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;

            pnlNoiDung.Controls.Add(frm);

            frm.Show();
            OpenForm(new QuanLyXe());
        }

        private void btnBaoTri_Click(object sender, EventArgs e)
        {
            pnlNoiDung.Controls.Clear();

           BaoTriXe frm = new BaoTriXe();

            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;

            pnlNoiDung.Controls.Add(frm);

            frm.Show();
        }

        private void pnlNoiDung_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            pnlNoiDung.Controls.Clear();

            ucDashboard uc = new ucDashboard(this);

            uc.Dock = DockStyle.Fill;

            pnlNoiDung.Controls.Add(uc);
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
           

            OpenForm(new ThongKe());

            pnlNoiDung.Controls.Clear();

            ThongKe frm = new ThongKe();

            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;

            pnlNoiDung.Controls.Add(frm);

            frm.Show();
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            pnlNoiDung.Controls.Clear();

            TaiKhoan frm = new TaiKhoan();

            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;

            pnlNoiDung.Controls.Add(frm);

            frm.Show();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnlNoiDung.Controls.Clear();

            HoaDon frm = new HoaDon();

            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;

            pnlNoiDung.Controls.Add(frm);

            frm.Show();
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            pnlNoiDung.Controls.Clear();

            QuanLyKH frm = new QuanLyKH();

            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;

            pnlNoiDung.Controls.Add(frm);

            frm.Show();
        }

        private void btnDangXuat_Click_1(object sender, EventArgs e)
        {
            

            this.Close();
        }

        private void pnlTittle_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblDateTime_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text =
        DateTime.Now.ToString(
        "dddd, dd/MM/yyyy - hh:mm:ss tt");
        }
    }
}
