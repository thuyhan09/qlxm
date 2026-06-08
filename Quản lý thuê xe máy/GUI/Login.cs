using System;
using System.Windows.Forms;
using Quản_lý_thuê_xe_máy.DAL;
using Quản_lý_thuê_xe_máy.DAL.Interfaces;

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
            IUserDAL userDAL = new UserDAL();

            var user = userDAL.Login(
                txtTaiKhoan.Text,
                txtMatKhau.Text
            );

            if (user != null)
            {
                MessageBox.Show("Đăng nhập thành công");

                Session.CurrentUser = user.Username;
                Session.CurrentRole = user.Role;

                frmChinh f = new frmChinh();

                this.Hide();

                f.ShowDialog();

                Session.CurrentUser = null;
                Session.CurrentRole = null;

                txtTaiKhoan.Clear();
                txtMatKhau.Clear();
                txtTaiKhoan.Focus();

                this.Show();
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