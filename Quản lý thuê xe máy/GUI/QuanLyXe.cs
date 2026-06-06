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

            dgvXe.Rows.Add("XM001", "Honda Vision", "43D1-123.45", "120,000 đ", "Sẵn sàng");
            dgvXe.Rows.Add("XM002", "Honda Air Blade", "43H1-567.89", "180,000 đ", "Đang thuê");
            dgvXe.Rows.Add("XM003", "Yamaha Exciter 155", "43E1-999.99", "250,000 đ", "Bảo trì");
            dgvXe.Rows.Add("XM004", "Honda SH Mode", "43M1-456.78", "300,000 đ", "Sẵn sàng");
            dgvXe.Rows.Add("XM005", "Yamaha Janus", "43J1-888.88", "150,000 đ", "Đang thuê");
            dgvXe.Rows.Add("XM006", "Honda Winner X", "43W1-222.22", "220,000 đ", "Sẵn sàng");
            dgvXe.Rows.Add("XM007", "Yamaha Grande", "43G1-333.33", "170,000 đ", "Sẵn sàng");
            dgvXe.Rows.Add("XM008", "Honda SH 160i", "43S1-444.44", "350,000 đ", "Đang thuê");
            dgvXe.Rows.Add("XM009", "Suzuki Raider", "43R1-555.55", "230,000 đ", "Bảo trì");
            dgvXe.Rows.Add("XM010", "VinFast Evo200", "43V1-666.66", "200,000 đ", "Sẵn sàng");
            

            dgvXe.Columns[4].DefaultCellStyle.Font =
                new Font("Segoe UI", 9, FontStyle.Bold);
        }

        private void dgvXe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvXe.Rows[e.RowIndex];

                txtMaXe.Text = row.Cells[0].Value.ToString();
                txtTenXe.Text = row.Cells[1].Value.ToString();
                txtBienSo.Text = row.Cells[2].Value.ToString();
                txtGiaThue.Text = row.Cells[3].Value.ToString();
                cboTrangThai.Text = row.Cells[4].Value.ToString();
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

                string maXe = row.Cells[0].Value.ToString().ToLower();
                string tenXe = row.Cells[1].Value.ToString().ToLower();
                string bienSo = row.Cells[2].Value.ToString().ToLower();

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
