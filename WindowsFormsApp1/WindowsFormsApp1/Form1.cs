using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Classes;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Classes.DataProcess dtbase = new Classes.DataProcess();
        //Classes.Function func = new Classes.Function();
        string fileAnh = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnBQ.Enabled = true;
            btnAnh.Enabled = true;

            LoadData();
        }

        private void btnBQ_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show(
                "Bạn có muốn bỏ qua không?",
                "Xác nhận",
                MessageBoxButtons.YesNo
                );
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }

        }

        void LoadData()
        {
            DataTable dt = dtbase.ReadTable("SELECT * FROM VatLieu");
            dgv.DataSource = dt;
            dgv.Columns["txtMaVL"].HeaderText = "Mã vật liệu";
            dgv.Columns["txtTenVL"].HeaderText = "Tên vật liệu";
            dgv.Columns["txtDVi"].HeaderText = "Đơn vị tính";
            dgv.Columns["txtGiaNhap"].HeaderText = "Giá nhập";
            dgv.Columns["txtGiaBan"].HeaderText = "Giá bán";
            dgv.Columns["SoLuong"].HeaderText = "Số lượng";
            dgv.Columns["Anh"].HeaderText = "Ảnh";
            dgv.Columns["GhiChu"].HeaderText = "Ghi chú";

            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }


    }
}
