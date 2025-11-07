using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanHangLuuNiem.DanhMuc
{
    public partial class frmKhachHang : Form
    {
        Classes.DataProcessor dtBase = new Classes.DataProcessor();

        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng này không?",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sqlDelete = "DELETE tblKhach WHERE MaKhach = '" + txtMaKhach.Text.Trim() + "'";
                dtBase.UpdateDB(sqlDelete);
                LoadData();
                ResetValue();
            }
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            LoadData();
            btnLuu.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnBoQua.Enabled = false;
        }

        private void LoadData()
        {
            DataTable dtKhach = dtBase.ReadTable("SELECT * FROM tblKhach");
            dgvKhachHang.DataSource = dtKhach;

            dgvKhachHang.Columns[0].HeaderText = "Mã khách";
            dgvKhachHang.Columns[1].HeaderText = "Tên khách";
            dgvKhachHang.Columns[2].HeaderText = "Địa chỉ";
            dgvKhachHang.Columns[3].HeaderText = "Điện thoại";

            dgvKhachHang.Columns[0].Width = 120;
            dgvKhachHang.Columns[1].Width = 200;
            dgvKhachHang.Columns[2].Width = 250;
            dgvKhachHang.Columns[3].Width = 150;
        }
        private void ResetValue()
        {
            txtMaKhach.Text = "";
            txtTenKhach.Text = "";
            txtDC.Text = "";
            txtDT.Text = "";
            txtMaKhach.Focus();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ResetValue();
            btnLuu.Enabled = true;
            btnBoQua.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaKhach.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập mã khách hàng!");
                txtMaKhach.Focus();
                return;
            }
            if (txtTenKhach.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập tên khách hàng!");
                txtTenKhach.Focus();
                return;
            }

            // Kiểm tra trùng mã khách
            DataTable dtCheck = dtBase.ReadTable("SELECT * FROM tblKhach WHERE MaKhach = '" + txtMaKhach.Text.Trim() + "'");
            if (dtCheck.Rows.Count > 0)
            {
                MessageBox.Show("Mã khách hàng đã tồn tại, vui lòng nhập mã khác!");
                txtMaKhach.Focus();
                return;
            }

            string sqlInsert = "INSERT INTO tblKhach VALUES('" + txtMaKhach.Text.Trim() +
                               "', N'" + txtTenKhach.Text.Trim() +
                               "', N'" + txtDC.Text.Trim() +
                               "', '" + txtDT.Text.Trim() + "')";

            dtBase.UpdateDB(sqlInsert);
            LoadData();
            ResetValue();

            btnLuu.Enabled = false;
            btnBoQua.Enabled = false;
            btnThem.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sqlUpdate = "UPDATE tblKhach SET TenKhach = N'" + txtTenKhach.Text.Trim() +
                               "', DiaChi = N'" + txtDC.Text.Trim() +
                               "', DienThoai = '" + txtDT.Text.Trim() +
                               "' WHERE MaKhach = '" + txtMaKhach.Text.Trim() + "'";

            dtBase.UpdateDB(sqlUpdate);
            LoadData();
            ResetValue();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dlg = MessageBox.Show("Bạn có muốn thoát không?", "Thoát",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlg == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            ResetValue();
            btnThem.Enabled = true;
            btnLuu.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnBoQua.Enabled = false;
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtMaKhach.Text = dgvKhachHang.CurrentRow.Cells[0].Value.ToString();
                txtTenKhach.Text = dgvKhachHang.CurrentRow.Cells[1].Value.ToString();
                txtDC.Text = dgvKhachHang.CurrentRow.Cells[2].Value.ToString();
                txtDT.Text = dgvKhachHang.CurrentRow.Cells[3].Value.ToString();

                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnBoQua.Enabled = true;
                btnThem.Enabled = false;
                btnLuu.Enabled = false;
            }
        }
    }
}
