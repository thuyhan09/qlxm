using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quản_lý_thuê_xe_máy.DAL;
using Quản_lý_thuê_xe_máy.DAL.Interfaces;
using Quản_lý_thuê_xe_máy.Entity;

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

            dgvBaoTri.Rows.Clear();

            IBaoTriDAL baoTriDAL = new BaoTriDAL();

            foreach (BaoTri bt in baoTriDAL.GetAll())
            {
                dgvBaoTri.Rows.Add(
                    bt.MaBaoTri,
                    bt.MaXe,
                    bt.LoaiBaoTri,
                    bt.NgayBaoTri.ToString("dd/MM/yyyy"),
                    bt.NoiDung,
                    bt.ChiPhi.ToString("N0"),
                    bt.NhaCungCap
                );
            }
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
