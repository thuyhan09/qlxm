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
    public partial class QuanLyKH : Form
    {
        public QuanLyKH()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.Form1_Load);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtDiaChi.Text);

            if (string.IsNullOrEmpty(txtMaKH.Text) || string.IsNullOrEmpty(txtHoTen.Text))
            {
                MessageBox.Show("Vui lòng nhập Mã khách hàng và Họ tên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            dgvKhachHang.Rows.Add(
                txtMaKH.Text,
                txtHoTen.Text,
                txtSDT.Text,
                
                cboHangHoiVien.Text,
                cboTuongTac.Text
            );

            MessageBox.Show("Đã thêm khách hàng mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtMaKH.Clear();
            txtHoTen.Clear();
            txtSDT.Clear();
            txtDiaChi.Clear();
            cboHangHoiVien.SelectedIndex = -1;
            cboTuongTac.SelectedIndex = -1;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

            if (dgvKhachHang.SelectedRows.Count > 0)
            {

                DataGridViewRow row = dgvKhachHang.SelectedRows[0];
                if (row.IsNewRow) return;
                txtMaKH.Text = row.Cells[0].Value?.ToString();
                txtHoTen.Text = row.Cells[1].Value?.ToString();
                txtSDT.Text = row.Cells[2].Value?.ToString();
                txtDiaChi.Text = row.Cells[3].Value?.ToString();
                cboHangHoiVien.Text = row.Cells[4].Value?.ToString();
                cboTuongTac.Text = row.Cells[5].Value?.ToString();

                txtMaKH.ReadOnly = true;

                MessageBox.Show("Đã tải thông tin khách hàng. Hãy chỉnh sửa ở khung bên trái rồi bấm nút LƯU để hoàn tất!", "Thông báo");
            }
            else
            {
                MessageBox.Show("Vui lòng click chọn một dòng khách hàng trên bảng trước khi bấm Sửa!", "Thông báo");
            }
            if (dgvKhachHang.SelectedRows.Count > 0)
            {

                DataGridViewRow selectedRow = dgvKhachHang.SelectedRows[0];

                txtMaKH.Text = selectedRow.Cells[0].Value.ToString();
                txtHoTen.Text = selectedRow.Cells[1].Value.ToString();
                txtSDT.Text = selectedRow.Cells[2].Value.ToString();
                cboHangHoiVien.Text = selectedRow.Cells[4].Value.ToString();
                cboTuongTac.Text = selectedRow.Cells[5].Value.ToString();

            }
            else
            {
                MessageBox.Show("Vui lòng click chọn một khách hàng trên bảng trước khi bấm Sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvKhachHang.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in dgvKhachHang.SelectedRows)
                    {
                        if (!row.IsNewRow)
                        {
                            dgvKhachHang.Rows.Remove(row);
                        }
                    }
                    MessageBox.Show("Đã xóa khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng click chọn một dòng khách hàng trên bảng trước khi bấm Xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvKhachHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvKhachHang.Rows.Add(
                "KH001",
                "Nguyễn Văn A",
                "0901112222",
                "123 Đường Lê Duẩn, Quận 1",
                "Vàng",
                "Đã liên hệ"
            );

            dgvKhachHang.Rows.Add(
                "KH002",
                "Trần Thị B",
                "0987776655",
                "456 Nguyễn Chí Thanh, Đà Nẵng",
                "Bạc",
                "Chưa liên hệ"
            );

            dgvKhachHang.Rows.Add(
                "KH003",
                "Lê Thanh Phương",
                "0912345678",
                "789 Cách Mạng Tháng 8, TP.HCM",
                "Đồng",
                "Đã liên hệ"
            );
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cboHangHoiVien_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboTuongTac_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtDiaChi_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtHoTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtMaKH_TextChanged(object sender, EventArgs e)
        {

        }
    }
}