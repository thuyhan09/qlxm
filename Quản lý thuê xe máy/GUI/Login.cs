using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

namespace Quản_lý_thuê_xe_máy
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string tk = txtTaiKhoan.Text;
            string mk = txtMatKhau.Text;

            var user = AppData.Users.FirstOrDefault(x =>
                x.Username == tk &&
                x.Password == mk);

            if (tk == TaiKhoanDangNhap.TenDangNhap
    && mk == TaiKhoanDangNhap.MatKhau)
            {
                MessageBox.Show("Đăng nhập thành công");

                frmChinh f = new frmChinh();
                this.Hide();      // Ẩn Login

                f.ShowDialog();   // Chờ frmChinh đóng

                this.Show();      // Hiện lại Login sau khi đăng xuất
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void chkHienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHienMatKhau.Checked) 
                txtMatKhau.PasswordChar = '\0';
            else 
                txtMatKhau.PasswordChar = '*';
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
