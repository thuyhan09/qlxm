using System;
using System.Drawing;
using System.Windows.Forms;
using Quản_lý_thuê_xe_máy.DAL;
using Quản_lý_thuê_xe_máy.DAL.Interfaces;
using Quản_lý_thuê_xe_máy.Entity;

namespace Quản_lý_thuê_xe_máy
{
    public partial class QuanLyXe : Form
    {
        public QuanLyXe()
        {
            InitializeComponent();
        }

        private void txtMaXe_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dgvXe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvXe.DefaultCellStyle.SelectionBackColor = Color.Bisque;
            dgvXe.DefaultCellStyle.SelectionForeColor = Color.Black;

            dgvXe.Rows.Clear();

            IXeDAL xeDAL = new XeDAL();

            foreach (Xe xe in xeDAL.GetAll())
            {
                dgvXe.Rows.Add(
                    xe.MaXe,
                    xe.TenXe,
                    xe.LoaiXe,
                    xe.GiaThue.ToString("N0"),
                    xe.TrangThai
                );
            }

            dgvXe.Columns[4].DefaultCellStyle.Font =
                new Font("Segoe UI", 9, FontStyle.Bold);
        }

        private void dgvXe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvXe.Rows[e.RowIndex];

                txtMaXe.Text = row.Cells[0].Value?.ToString();
                txtTenXe.Text = row.Cells[1].Value?.ToString();
                txtBienSo.Text = row.Cells[2].Value?.ToString();
                txtGiaThue.Text = row.Cells[3].Value?.ToString();
                cboTrangThai.Text = row.Cells[4].Value?.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            dgvXe.Rows.Add(
                txtMaXe.Text,
                txtTenXe.Text,
                txtBienSo.Text,
                txtGiaThue.Text,
                cboTrangThai.Text
            );

            MessageBox.Show("Thêm xe thành công!");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvXe.CurrentRow != null)
            {
                dgvXe.CurrentRow.Cells[0].Value = txtMaXe.Text;
                dgvXe.CurrentRow.Cells[1].Value = txtTenXe.Text;
                dgvXe.CurrentRow.Cells[2].Value = txtBienSo.Text;
                dgvXe.CurrentRow.Cells[3].Value = txtGiaThue.Text;
                dgvXe.CurrentRow.Cells[4].Value = cboTrangThai.Text;

                MessageBox.Show("Cập nhật thành công!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvXe.CurrentRow != null)
            {
                dgvXe.Rows.Remove(dgvXe.CurrentRow);
                MessageBox.Show("Xóa xe thành công!");
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string tuKhoa = txtTimKiem.Text.Trim().ToLower();

            foreach (DataGridViewRow row in dgvXe.Rows)
            {
                if (row.IsNewRow) continue;

                string maXe = row.Cells[0].Value?.ToString().ToLower() ?? "";
                string tenXe = row.Cells[1].Value?.ToString().ToLower() ?? "";
                string bienSo = row.Cells[2].Value?.ToString().ToLower() ?? "";

                row.Visible =
                    maXe.Contains(tuKhoa) ||
                    tenXe.Contains(tuKhoa) ||
                    bienSo.Contains(tuKhoa);
            }
        }

        private void panelTrai_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}