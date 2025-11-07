using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dqh
{
    public partial class Form1 : Form
    {
        Classes.DataProcess dtBase = new Classes.DataProcess();
        Classes.Function ft = new Classes.Function();
        string fileAnh = "";

        public Form1()
        {
            InitializeComponent();
        }

        

        private void btnSua_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboPhongBan_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ban co muon xoa khong?", "Xoa MaNV",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dtBase.UpdateDB("Delete tblHang where MaNV='" + txtMaNV.Text + "'");
                dgv.DataSource = dtBase.ReadTable("select * from tblNhanVien");
            }

            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = true;

            ResetValue();
        }

        private void btnAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgAnh = new OpenFileDialog();
            dlgAnh.Filter = "All files(*.*)|*.*";
            dlgAnh.InitialDirectory = Application.StartupPath;
            dlgAnh.FilterIndex = 3;
            dlgAnh.Title = "Chọn ảnh để hiển thị";
            if (dlgAnh.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                picAnh.Image = Image.FromFile(dlgAnh.FileName);
                string[] str = dlgAnh.FileName.Split('\\');
                fileAnh = str[str.Length - 1].ToString();
            }
        }
        void ResetValue()
        {
            txtMaNV.Text = "";
            txtTenNV.Text = "";
            txtSDT.Text = "";
            txtLuong.Text = "";
            txtMaNV.Focus();
            txtTenNV.Focus();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {

        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
