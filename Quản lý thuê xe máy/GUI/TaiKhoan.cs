using System;
using System.Drawing;
using System.Windows.Forms;
using Quản_lý_thuê_xe_máy.DAL;
using Quản_lý_thuê_xe_máy.DAL.Interfaces;
using Quản_lý_thuê_xe_máy.Entity;

namespace Quản_lý_thuê_xe_máy
{
    public partial class TaiKhoan : Form
    {
        private readonly IUserDAL userDAL = new UserDAL();

        public TaiKhoan()
        {
            InitializeComponent();
        }

        private void lblVaiTro_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void chkHienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            bool hien = chkHienMatKhau.Checked;

            txtMatKhauCu.PasswordChar = hien ? '\0' : '*';
            txtMatKhauMoi.PasswordChar = hien ? '\0' : '*';
            txtNhapLaiMK.PasswordChar = hien ? '\0' : '*';
        }

        private void pnlTaiKhoan_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlDoiMatKhau_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            frmChinh frm = (frmChinh)this.ParentForm;
            frm.Close();
        }

        private void btnAvt_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();

            open.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            open.Title = "Chọn ảnh đại diện";

            if (open.ShowDialog() == DialogResult.OK)
            {
                picAvatar.Image = Image.FromFile(open.FileName);
                picAvatar.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void TaiKhoan_Load(object sender, EventArgs e)
        {
            cboVaiTro.Items.Clear();

            cboVaiTro.Items.Add("Admin");
            cboVaiTro.Items.Add("Nhân viên");

            cboVaiTro.SelectedIndex = 0;

            if (!string.IsNullOrEmpty(Session.CurrentUser))
            {
                User user =
                    userDAL.GetByUsername(Session.CurrentUser);

                if (user != null)
                {
                    txtTenDangNhap.Text = user.Username;
                    cboVaiTro.Text = user.Role;
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string username = txtTenDangNhap.Text;

            User user =
                userDAL.GetByUsername(username);

            if (user == null)
            {
                MessageBox.Show("Không tìm thấy user!");
                return;
            }

            user.Role = cboVaiTro.Text;

            userDAL.Update(user);

            MessageBox.Show("Cập nhật thành công!");
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            string mkCu = txtMatKhauCu.Text;
            string mkMoi = txtMatKhauMoi.Text;
            string xacNhan = txtNhapLaiMK.Text;

            User user =
                userDAL.GetByUsername(Session.CurrentUser);

            if (user == null)
            {
                MessageBox.Show("Không tìm thấy tài khoản!");
                return;
            }

            if (mkCu != user.Password)
            {
                MessageBox.Show("Mật khẩu cũ không đúng!");
                return;
            }

            if (mkMoi != xacNhan)
            {
                MessageBox.Show("Xác nhận mật khẩu không khớp!");
                return;
            }

            user.Password = mkMoi;

            userDAL.Update(user);

            MessageBox.Show("Đổi mật khẩu thành công!");
        }
    }
}