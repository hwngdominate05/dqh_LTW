using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai3_Thuchanh
{
    public partial class Form1 : Form
    {
        private double giaCoca = 0.5;
        private double giaPepsi = 0.8;
        private double giaSevenUp = 1.0;
        public Form1()
        {
            InitializeComponent();

            this.Load += Form1_Load;

            btnThemDS.Text = "Thêm vào DS";
            btnThemMoi.Text = "Thêm Mới";
            btnThoat.Text = "Thoát";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboDoUong.Items.Add("Coca cola");
            cboDoUong.Items.Add("Pepsi");
            cboDoUong.Items.Add("Seven Up");

            for (int i = 1; i <= 10; i++)
            {
                cboSoLuong.Items.Add(i.ToString());
            }

            txtGiaDuThuyen.ReadOnly = true;
            txtTien.ReadOnly = true;
            
        }
        

        private void rdoCaNgay_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoCaNgay.Checked)
                txtGiaDuThuyen.Text = "200";
        }

        private void rdoNuaNgay_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoNuaNgay.Checked)
                txtGiaDuThuyen.Text = "100";
        }

        private void cboDoUong_SelectedIndexChanged(object sender, EventArgs e)
        {
            TinhTienDoUong();
        }

        private void cboSoLuong_SelectedIndexChanged(object sender, EventArgs e)
        {
            TinhTienDoUong();
        }

        private void TinhTienDoUong()
        {
            if (cboDoUong.SelectedItem == null || cboSoLuong.SelectedItem == null) return;

            string doUong = cboDoUong.SelectedItem.ToString();
            int soLuong = int.Parse(cboSoLuong.SelectedItem.ToString());
            double donGia = 0;

            switch (doUong)
            {
                case "Coca cola": donGia = giaCoca; break;
                case "Pepsi": donGia = giaPepsi; break;
                case "Seven Up": donGia = giaSevenUp; break;
            }

            double tien = donGia * soLuong;
            txtTien.Text = tien.ToString("0.0");
        }
        private void btnThemDS_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Hãy nhập họ tên khách hàng!");
                txtHoTen.Focus();
                return;
            }

            string item = txtHoTen.Text + " | ";

            if (rdoCaNgay.Checked)
                item += "Cả ngày | " + txtGiaDuThuyen.Text + "$ | ";
            else if (rdoNuaNgay.Checked)
                item += "Nửa ngày | " + txtGiaDuThuyen.Text + "$ | ";
            if (cboDoUong.SelectedItem != null)
                item += "Đồ uống" + txtTien.Text + " $ | ";

            double tong = 0;
            if (double.TryParse(txtGiaDuThuyen.Text, out double giaDuThuyen))
                tong += giaDuThuyen;
            if (double.TryParse(txtTien.Text, out double tien))
                tong += tien;

            item += "Tổng " + tong.ToString("0.0") + "$";

            lstKhachHang.Items.Add(item);
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            txtHoTen.Clear();
            txtGiaDuThuyen.Clear();
            txtTien.Clear();
            cboDoUong.SelectedIndex = -1;
            cboSoLuong.SelectedIndex = -1;
            rdoCaNgay.Checked = false;
            rdoNuaNgay.Checked = false;

            txtHoTen.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có muốn thoát không?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
