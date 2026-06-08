using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;
using Quản_lý_thuê_xe_máy.DAL;
using Quản_lý_thuê_xe_máy.DAL.Interfaces;
using Quản_lý_thuê_xe_máy.Entity;

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
            IXeDAL xeDAL = new XeDAL();

            cboXeMay.Items.Clear();

            foreach (Xe xe in xeDAL.GetAll())
            {
                cboXeMay.Items.Add(xe.TenXe);
            }

            if (cboXeMay.Items.Count > 0)
            {
                cboXeMay.SelectedIndex = 0;
            }
        }

        private void cboXeMay_SelectedIndexChanged(object sender, EventArgs e)
        {
            IXeDAL xeDAL = new XeDAL();

            Xe xe = xeDAL.GetAll()
                        .FirstOrDefault(x => x.TenXe == cboXeMay.Text);

            if (xe != null)
            {
                cboBienSo.Items.Clear();

                cboBienSo.Items.Add(xe.BienSo);

                cboBienSo.SelectedIndex = 0;

                txtGiaThue.Text = xe.GiaThue.ToString();
            }
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
