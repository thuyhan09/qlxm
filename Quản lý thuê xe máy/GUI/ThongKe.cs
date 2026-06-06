using System;
using System.Windows.Forms;

namespace Quản_lý_thuê_xe_máy.cs
{
    public partial class ThongKe : Form
    {
        decimal tongDoanhThu = 0;
        int tongLuotThue = 0;
        int xeDangThue = 0;
      
            public ThongKe()
            {
                InitializeComponent();
            }

           
            private void CapNhatThongKe()
            {
                lblDoanhThu.Text =
                    tongDoanhThu.ToString("N0") + " đ";

                lblLuotThue.Text =
                    tongLuotThue.ToString();

                lblXeDangThue.Text =
                    xeDangThue.ToString();

                lblTongDoanhThu.Text =
                    "Tổng doanh thu: "
                    + tongDoanhThu.ToString("N0")
                    + " VNĐ";
            }

            private void btnDoanhThu_Click(object sender, EventArgs e)
            {
                tongDoanhThu += 500000;

                dgvThongKe.Rows.Add(
                    dgvThongKe.Rows.Count + 1,
                    "Tháng 6",
                    "Vision",
                    "500.000 VNĐ"
                );

                CapNhatThongKe();
            }

        private void btnLuotThue_Click(object sender, EventArgs e)
        {
            tongLuotThue++;

            xeDangThue++;

            tongDoanhThu += 500000;

            dgvThongKe.Rows.Add(
                dgvThongKe.Rows.Count + 1,
                "Tháng 6",
                "Vision",
                "500.000 VNĐ"
            );

            CapNhatThongKe();
        }
       
    
 

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvThongKe.Columns.Clear();

            dgvThongKe.Columns.Add("STT", "STT");
            dgvThongKe.Columns.Add("Thang", "Tháng");
            dgvThongKe.Columns.Add("TenXe", "Tên xe");
            dgvThongKe.Columns.Add("DoanhThu", "Doanh thu");

            dgvThongKe.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            // Danh sách tháng
            for (int i = 1; i <= 12; i++)
            {
                cboThang.Items.Add("Tháng " + i);
            }

            // Danh sách xe
            cboXe.Items.Add("Vision");
            cboXe.Items.Add("Wave Alpha");
            cboXe.Items.Add("Air Blade");
            cboXe.Items.Add("Winner X");
            cboXe.Items.Add("SH Mode");

            // Dữ liệu mẫu
            dgvThongKe.Rows.Add("1", "Tháng 1", "Vision", "5.000.000");
            dgvThongKe.Rows.Add("2", "Tháng 2", "Wave Alpha", "7.500.000");
            dgvThongKe.Rows.Add("3", "Tháng 3", "Air Blade", "6.200.000");

            tongDoanhThu = 18700000;
            tongLuotThue = 37;
            xeDangThue = 8;

            CapNhatThongKe();
        }

       

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (cboThang.Text == "" ||
                cboXe.Text == "" ||
                txtDoanhThu.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            decimal doanhThu;

            if (!decimal.TryParse(txtDoanhThu.Text, out doanhThu))
            {
                MessageBox.Show("Doanh thu phải là số!");
                return;
            }

            dgvThongKe.Rows.Add(
                dgvThongKe.Rows.Count + 1,
                cboThang.Text,
                cboXe.Text,
                doanhThu.ToString("N0")
            );

            tongDoanhThu += doanhThu;
            tongLuotThue++;
            xeDangThue++;

            CapNhatThongKe();

            cboThang.SelectedIndex = -1;
            cboXe.SelectedIndex = -1;
            txtDoanhThu.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblTongDoanhThu_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}