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
    public partial class TaiKhoan : Form
    {
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
            cboVaiTro.Items.Add("Admin");
            cboVaiTro.Items.Add("Nhân viên");
            

            cboVaiTro.SelectedIndex = 0;
            string vaiTro = cboVaiTro.SelectedItem.ToString();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string username = txtTenDangNhap.Text;
            string roleMoi = cboVaiTro.SelectedItem.ToString();

            var user = AppData.Users.FirstOrDefault(x => x.Username == username);

            if (user != null)
            {
                user.Role = roleMoi;

                MessageBox.Show("Cập nhật thành công!");
            }

            else
            {
                MessageBox.Show("Không tìm thấy user!");
            }
            
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            string mkCu = txtMatKhauCu.Text;
            string mkMoi = txtMatKhauMoi.Text;
            string xacNhan = txtNhapLaiMK.Text;

            if (mkCu != TaiKhoanDangNhap.MatKhau)
            {
                MessageBox.Show("Mật khẩu cũ không đúng!");
                return;
            }

            if (mkMoi != xacNhan)
            {
                MessageBox.Show("Xác nhận mật khẩu không khớp!");
                return;
            }

            TaiKhoanDangNhap.MatKhau = mkMoi;

            MessageBox.Show("Đổi mật khẩu thành công!");
        }
    }
}
