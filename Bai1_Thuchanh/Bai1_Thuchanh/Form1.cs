using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1_Thuchanh
{
    public partial class Form1 : Form
    {
        Dictionary<string, int> monHoc = new Dictionary<string, int>()
        {
            {"Tin học đại cương", 2},
            {"Giải tích F1", 3},
            {"Tiếng Anh A0", 3},
            {"Triết học Mác – Lênin", 2},
            {"Vật lý F1", 3}
        };

        public Form1()
        {
            InitializeComponent();

            foreach(var mh in monHoc.Keys)
            {
                cboMonHoc.Items.Add(mh);
            }

            txtSoTinChi.ReadOnly = true;

            btnThem.Text = "Thêm vào DS";
            btnTinh.Text = "Tính";
            btnThoat.Text = "Thoát";
        }

        private void cboMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tenMH = cboMonHoc.SelectedItem.ToString();
            if (monHoc.ContainsKey(tenMH))
            {
                txtSoTinChi.Text = monHoc[tenMH].ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(!double.TryParse(txtDiem.Text, out var diem))
            {
                MessageBox.Show("Điểm phải là số, vui lòng nhập lại!");
                txtDiem.Focus();
                return;
            }
            if (cboMonHoc.SelectedItem != null)
            {
                string tenMH = cboMonHoc.SelectedItem.ToString();
                int soTC = monHoc[tenMH];

                ListViewItem row = new ListViewItem(tenMH);
                row.SubItems.Add(soTC.ToString());
                row.SubItems.Add(diem.ToString("0.0"));
                lvMonHoc.Items.Add(row);
            }
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            if (lvMonHoc.Items.Count == 0)
            {
                MessageBox.Show("Danh sách rỗng, hãy thêm môn học!");
                return;
            }

            int tongTC = 0;
            double tongDiem = 0;

            foreach (ListViewItem item in lvMonHoc.Items)
            {
                int soTC = int.Parse(item.SubItems[1].Text);
                double diem = double.Parse(item.SubItems[2].Text);

                tongTC += soTC;
                tongDiem += soTC * diem;
            }

            double diemTB = tongDiem / tongTC;

            txtTongTinChi.Text = tongTC.ToString();
            txtTongDiem.Text = tongDiem.ToString("0.0");
            txtDiemTB.Text = diemTB.ToString("0.0");

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

        private void lvMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
