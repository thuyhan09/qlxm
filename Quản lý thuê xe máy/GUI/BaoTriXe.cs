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
    public partial class BaoTriXe : Form
    {
        public BaoTriXe()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dgvBaoTri_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            dgvBaoTri.DefaultCellStyle.SelectionBackColor = Color.Bisque;
            dgvBaoTri.DefaultCellStyle.SelectionForeColor = Color.Black;

            dgvBaoTri.Rows.Add("BT001", "XM011", "Định kỳ", "01/06/2026", "Thay nhớt, kiểm tra phanh", "500,000 đ", "Honda");
            dgvBaoTri.Rows.Add("BT002", "XM010", "Sửa chữa lớn", "15/05/2026", "Thay lốp", "1,200,000 đ", "Yamaha");
            dgvBaoTri.Rows.Add("BT003", "XM008", "Định kỳ", "05/06/2026", "Bảo dưỡng động cơ", "500,000 đ", "Honda");


        }
        private void dgvBaoTri_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvBaoTri.Rows[e.RowIndex];

                txtMaBaoTri.Text = row.Cells[0].Value.ToString();
                txtMaXe.Text = row.Cells[1].Value.ToString();
                cboLoaiBaoTri.Text = row.Cells[2].Value.ToString();

                dtNgayBaoTri.Value =
                    Convert.ToDateTime(row.Cells[3].Value);

                rtbNoiDung.Text = row.Cells[4].Value.ToString();
                txtChiPhi.Text = row.Cells[5].Value.ToString();
                txtNhaCungCap.Text = row.Cells[6].Value.ToString();
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            dgvBaoTri.Rows.Add(
        txtMaBaoTri.Text,
        txtMaXe.Text,
        cboLoaiBaoTri.Text,
        dtNgayBaoTri.Text,
        rtbNoiDung.Text,
        txtChiPhi.Text,
        txtNhaCungCap.Text
    );

            MessageBox.Show("Thêm bảo trì thành công!");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvBaoTri.CurrentRow != null)
            {
                dgvBaoTri.CurrentRow.Cells[0].Value = txtMaBaoTri.Text;
                dgvBaoTri.CurrentRow.Cells[1].Value = txtMaXe.Text;
                dgvBaoTri.CurrentRow.Cells[2].Value = cboLoaiBaoTri.Text;
                dgvBaoTri.CurrentRow.Cells[3].Value = dtNgayBaoTri.Text;
                dgvBaoTri.CurrentRow.Cells[4].Value = rtbNoiDung.Text;
                dgvBaoTri.CurrentRow.Cells[5].Value = txtChiPhi.Text;
                dgvBaoTri.CurrentRow.Cells[6].Value = txtNhaCungCap.Text;

                MessageBox.Show("Cập nhật thành công!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvBaoTri.CurrentRow != null)
            {
                dgvBaoTri.Rows.Remove(dgvBaoTri.CurrentRow);
                MessageBox.Show("Xóa bảo trì thành công!");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
