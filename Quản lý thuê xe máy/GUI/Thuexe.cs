using Quản_lý_thuê_xe_máy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dangnhap
{
    public partial class Thuexe : Form
    {
        public Thuexe()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void Thuexe_Load(object sender, EventArgs e)
        {

        }

        private void txtTongTien_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSoNgay_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbXeMay_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
        "Lưu thành công!",
        "Thông báo",
        MessageBoxButtons.OK,
        MessageBoxIcon.Information);

            frmChinh frm = (frmChinh)Application.OpenForms["frmChinh"];

            if (frm != null)
            {
                frm.OpenForm(new QuanLyXe());
            }

        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            cmbKhachHang.SelectedIndex = -1;

            cmbXeMay.SelectedIndex = -1;

            txtBienSo.Clear();

            txtGiaThue.Clear();

            txtSoNgay.Clear();

            txtTienCoc.Clear();

            txtTongTien.Clear();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nudSoNgay_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
