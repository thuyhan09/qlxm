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
    public partial class HoaDon : Form
    {
        public HoaDon()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void HoaDon_Load(object sender, EventArgs e)
        {
            cboXeMay.Items.Add("Honda Vision");
            cboXeMay.Items.Add("Honda Wave Alpha");
            cboXeMay.Items.Add("Honda Air Blade");
            cboXeMay.Items.Add("Yamaha Sirius");
            cboXeMay.Items.Add("Yamaha Exciter");

            cboXeMay.SelectedIndex = 0;

        }

        private void cboXeMay_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboBienSo.Items.Clear();

            switch (cboXeMay.Text)
            {
                case "Honda Vision":
                    cboBienSo.Items.Add("75A-12345");
                    cboBienSo.Items.Add("75A-12346");
                    cboBienSo.Items.Add("75A-12347");
                    txtGiaThue.Text = "150000";
                    break;

                case "Honda Wave Alpha":
                    cboBienSo.Items.Add("75A-56789");
                    cboBienSo.Items.Add("75A-56790");
                    txtGiaThue.Text = "120000";
                    break;

                case "Honda Air Blade":
                    cboBienSo.Items.Add("75A-88888");
                    cboBienSo.Items.Add("75A-88889");
                    txtGiaThue.Text = "180000";
                    break;

                case "Yamaha Sirius":
                    cboBienSo.Items.Add("75A-22222");
                    cboBienSo.Items.Add("75A-22223");
                    txtGiaThue.Text = "120000";
                    break;

                case "Yamaha Exciter":
                    cboBienSo.Items.Add("75A-99999");
                    cboBienSo.Items.Add("75A-99998");
                    txtGiaThue.Text = "250000";
                    break;
            }

            if (cboBienSo.Items.Count > 0)
                cboBienSo.SelectedIndex = 0;
        }

        private void nudSoNgay_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            int soNgay = (int)nudSoNgay.Value;

            decimal giaThue = decimal.Parse(txtGiaThue.Text);

            decimal thanhTien = soNgay * giaThue;

            txtThanhTien.Text = thanhTien.ToString("N0");
        }

        private void nudSoNgay_ValueChanged(object sender, EventArgs e)
        {
            int soNgay = (dtpNgayTra.Value - dtpNgayThue.Value).Days;

            if (soNgay <= 0)
            {
                MessageBox.Show("Ngày trả phải lớn hơn ngày thuê!");
                return;
            }

            nudSoNgay.Value = soNgay;

            decimal giaThue = decimal.Parse(txtGiaThue.Text);

            decimal thanhTien = soNgay * giaThue;

            txtThanhTien.Text = thanhTien.ToString("N0");
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show(
        "Bạn có chắc chắn muốn in hóa đơn này?",
        "XÁC NHẬN IN HÓA ĐƠN",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question);

            if (kq == DialogResult.Yes)
            {
                MessageBox.Show(
                    "🎉 In hóa đơn thành công!\n\n" +
                    "Hóa đơn đã được lưu vào hệ thống.",
                    "THÀNH CÔNG",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
    }
}
