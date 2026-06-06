using Dangnhap;
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
    public partial class ucDashboard : UserControl

    {
        public ucDashboard(frmChinh main)
        {
            InitializeComponent();
            frmMain = main;
            this.Load += ucDashboard_Load;
        }
        private frmChinh frmMain;
        private DataTable dtDangThue = new DataTable();

        private void lblDate_Click(object sender, EventArgs e)
        {

        }

        private void dgvDangThue_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ucDashboard_Load(object sender, EventArgs e)
        {
            if (dtDangThue.Columns.Count == 0)
            {
                dtDangThue.Columns.Add("MaHD");
                dtDangThue.Columns.Add("TenKH");
                dtDangThue.Columns.Add("TenXe");
                dtDangThue.Columns.Add("BienSo");
                dtDangThue.Columns.Add("NgayTra");
                dtDangThue.Columns.Add("TrangThai");
            }
            dtDangThue.Rows.Clear();

            dtDangThue.Rows.Add(
                "HD001",
                "Nguyễn Văn A",
                "Vision",
                "75A-12345",
                "10/06/2026",
                "Đang thuê");

            dtDangThue.Rows.Add(
                "HD002",
                "Trần Văn B",
                "Wave Alpha",
                "75A-67890",
                "12/06/2026",
                "Đang thuê");

            dgvDangThue.DataSource = dtDangThue;

            dgvDangThue.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvDangThue.RowHeadersVisible = false;

            dgvDangThue.AllowUserToAddRows = false;

            dgvDangThue.ReadOnly = true;
        }


        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnTaoPhieu_Click(object sender, EventArgs e)
        {
            frmMain.OpenForm(new Thuexe());
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtSearch.Text.Trim();

            DataView dv = dtDangThue.DefaultView;

            dv.RowFilter =
                $"MaHD LIKE '%{tuKhoa}%' OR " +
                $"TenKH LIKE '%{tuKhoa}%' OR " +
                $"TenXe LIKE '%{tuKhoa}%' OR " +
                $"BienSo LIKE '%{tuKhoa}%'";

            dgvDangThue.DataSource = dv;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch.PerformClick();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
