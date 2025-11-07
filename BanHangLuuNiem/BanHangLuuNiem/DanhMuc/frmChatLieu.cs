using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BanHangLuuNiem.DanhMuc
{
    
    public partial class frmChatLieu : Form
    {
        Classes.DataProcessor dtBase = new Classes.DataProcessor();

        public frmChatLieu()
        {
            InitializeComponent();
        }

        private void frmChatLieu_Load(object sender, EventArgs e)
        {
            DataTable dtChatLieu = dtBase.ReadTable("select * from tblChatLieu");
            dgv.DataSource = dtChatLieu;
            dgv.Columns[0].HeaderText = "Mã Chất Liệu";
            dgv.Columns[1].HeaderText = "Tên Chất Liệu";
            dgv.Columns[0].Width = 150;
            dgv.Columns[1].Width = 300;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            btnBoQua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
            btnBoQua.Enabled = false;
        }
        private void ResetValue()
        {
            txtMaCL.Text = "";
            txtTenCL.Text = "";
            txtMaCL.Focus();
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtMaCL.Text = dgv.CurrentRow.Cells[0].Value.ToString();
                txtTenCL.Text = dgv.CurrentRow.Cells[1].Value.ToString();

                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnBoQua.Enabled = true;
                btnThem.Enabled = false;
                btnLuu.Enabled = false;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnBoQua.Enabled = true;
            btnThem.Enabled = false;

            ResetValue();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaCL.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập mã chất liệu!");
                txtMaCL.Focus();
                return;
            }
            if (txtTenCL.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập tên chất liệu!");
                txtTenCL.Focus();
                return;
            }

            if (btnThem.Enabled == false)
            {
                DataTable dtCheck = dtBase.ReadTable("SELECT * FROM tblChatLieu WHERE MaChatLieu='" + txtMaCL.Text.Trim() + "'");
                if (dtCheck.Rows.Count > 0)
                {
                    MessageBox.Show("Mã chất liệu đã tồn tại!");
                    txtMaCL.Focus();
                    return;
                }

                // Thêm mới
                string sqlInsert = "INSERT INTO tblChatLieu VALUES('" + txtMaCL.Text + "', N'" + txtTenCL.Text + "')";
                dtBase.UpdateDB(sqlInsert);
            }

            if (btnSua.Enabled == true)
            {
                string sqlUpdate = "UPDATE tblChatLieu SET TenChatLieu=N'" + txtTenCL.Text + "' WHERE MaChatLieu='" + txtMaCL.Text + "'";
                dtBase.UpdateDB(sqlUpdate);
            }

            dgv.DataSource = dtBase.ReadTable("SELECT * FROM tblChatLieu");

            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
            btnBoQua.Enabled = false;
            btnThem.Enabled = true;
            ResetValue();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnBoQua.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa chất liệu này không?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sqlDelete = "DELETE FROM tblChatLieu WHERE MaChatLieu='" + txtMaCL.Text + "'";
                dtBase.UpdateDB(sqlDelete);
                dgv.DataSource = dtBase.ReadTable("SELECT * FROM tblChatLieu");
            }

            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
            btnBoQua.Enabled = false;
            btnThem.Enabled = true;
            ResetValue();
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
            btnBoQua.Enabled = false;
            btnThem.Enabled = true;
            ResetValue();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
