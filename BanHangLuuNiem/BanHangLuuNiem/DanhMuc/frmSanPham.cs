using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;



namespace BanHangLuuNiem.DanhMuc
{
    public partial class frmSanPham : Form
    {
        Classes.DataProcessor dtBase = new Classes.DataProcessor();
        Classes.Function ft = new Classes.Function();
        string fileAnh = "";

        public frmSanPham()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmSanPham_Load(object sender, EventArgs e)
        {
            DataTable dtChatLieu = dtBase.ReadTable("Select * from tblChatLieu");
            ft.FillComBox(cboChatLieu, dtChatLieu, "TenChatLieu", "MaChatLieu");
            cboChatLieu.SelectedIndex = -1;
            DataTable dtHang = dtBase.ReadTable("select * from tblHang");
            dgvHang.DataSource = dtHang;
            dgvHang.Columns[0].HeaderText = "Mã hàng";
            dgvHang.Columns[1].HeaderText = "Tên hàng";
            dgvHang.Columns[2].HeaderText = "Mã CL";
            dgvHang.Columns[3].HeaderText = "Số lượng";
            dgvHang.Columns[4].HeaderText = "Giá nhập";
            dgvHang.Columns[5].HeaderText = "Giá bán";
            dgvHang.Columns[6].HeaderText = "File ảnh";

            dgvHang.Columns[0].Width = 150;
            dgvHang.Columns[1].Width = 250;
            dgvHang.Columns[2].Width = 150;
            dgvHang.Columns[3].Width = 150;
            dgvHang.Columns[4].Width = 150;
            dgvHang.Columns[5].Width = 150;
            dgvHang.Columns[6].Width = 150;

            dgvHang.BackgroundColor = Color.LightBlue;
            dtHang.Dispose();

            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
            btnBoQua.Enabled = false;

            ResetValue();

        }
        void HienThiChiTiet(bool hien)
        {
            txtDonGiaBan.Enabled = hien;
            txtDonGiaNhap.Enabled = hien;
            txtGhiChu.Enabled = hien;
            txtMaHang.Enabled = hien;
            txtSoLuong.Enabled = hien;
            txtTenHang.Enabled = hien;
            cboChatLieu.Enabled = hien;
            picAnh.Enabled = hien;
            btnAnh.Enabled = hien;
            btnLuu.Enabled = hien;
            btnBoQua.Enabled = hien;
        }
        
        
        private void dgvHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnBoQua.Enabled = true;
            btnThem.Enabled = false;
            btnLuu.Enabled = false;

            txtMaHang.Text = dgvHang.CurrentRow.Cells[0].Value.ToString();
            txtTenHang.Text = dgvHang.CurrentRow.Cells[1].Value.ToString();
            cboChatLieu.Text = dgvHang.CurrentRow.Cells[2].Value.ToString();
            txtSoLuong.Text = dgvHang.CurrentRow.Cells[3].Value.ToString();
            txtDonGiaNhap.Text = dgvHang.CurrentRow.Cells[4].Value.ToString();
            txtDonGiaBan.Text = dgvHang.CurrentRow.Cells[5].Value.ToString();
            try
            {
                picAnh.Image = Image.FromFile("Images\\Hang\\" + dgvHang.CurrentRow.Cells[6].Value.ToString());
            }
            catch { }


        }

        private void btnAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgAnh = new OpenFileDialog();
            dlgAnh.Filter = "Bitmap(*.bmp) | *.bmp |Gif(*.gif) |*.gif|All files(*.*)|*.*";
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

        private void btnSua_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnBoQua.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = true;
            btnLuu.Enabled = true;
            btnBoQua.Enabled = true;

            ResetValue();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(txtMaHang.Text.Trim() == "")
            {
                MessageBox.Show("Ban phai nhap ma hang");
                txtMaHang.Focus();
                return;
            }
            if(txtTenHang.Text.Trim() == "")
            {
                MessageBox.Show("Ban phai nhap ten hang");
                txtTenHang.Focus();
                return;
            }
            if (cboChatLieu.Text.Trim() == "")
            {
                MessageBox.Show("Ban phai chon chat lieu");
                return;
            }
            if(txtSoLuong.Text.Trim() == "")
            {
                MessageBox.Show("Ban [hai nhap so luong");
                txtSoLuong.Focus();
                return;
            }
            if(txtDonGiaNhap.Text.Trim() == "")
            {
                MessageBox.Show("Ban phai nhap gia nhap");
                txtDonGiaNhap.Focus();
                return;
            }
            if(txtDonGiaBan.Text.Trim() == "")
            {
                MessageBox.Show("Ban phai nhap gia ban");
                txtDonGiaBan.Focus();
                return;
            }

            if (btnThem.Enabled == true)
            {
                DataTable dtSP = dtBase.ReadTable("Select * from tblHang where MaHang='" + txtMaHang.Text + "'");
                if (dtSP.Rows.Count > 0)
                {
                    MessageBox.Show("Ma san pham da ton tai. Moi ban nhap ma khac");
                    txtMaHang.Focus();
                    return;
                }
                string strInsert = "Insert into tblHang values('" + txtMaHang.Text + "',N'" + txtTenHang.Text + "','" + cboChatLieu.SelectedValue + "'," + int.Parse(txtSoLuong.Text) + "," + float.Parse(txtDonGiaNhap.Text) + "," + float.Parse(txtDonGiaBan.Text) + ",'" + fileAnh + "',N'" + txtGhiChu.Text + "')";
                dtBase.UpdateDB(strInsert);
            }
            if (btnSua.Enabled == true)
            {
                string sqlUpdate = "update tblHang set TenHang=N'" + txtTenHang.Text + "',MaChatLieu='" + cboChatLieu.SelectedValue + "',SoLuong=" + Convert.ToInt16(txtSoLuong.Text) + ",DonGiaNhap=" + float.Parse(txtDonGiaNhap.Text) + ",DonGiaBan=" + float.Parse(txtDonGiaBan.Text) + ",Anh='" + fileAnh + "',GhiChu=N'" + txtGhiChu.Text + "'where MaHang'" + txtMaHang.Text + "'";
                dtBase.UpdateDB(sqlUpdate);
            }
            DataTable dtHang = dtBase.ReadTable("Select * from tblHang");
            dgvHang.DataSource = dtHang;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
            btnBoQua.Enabled = false;
            btnThem.Enabled = true;

            ResetValue();
        }

        void ResetValue()
        {
            txtMaHang.Text = "";
            txtTenHang.Text = "";
            cboChatLieu.Text = "";
            txtSoLuong.Text = "";
            txtDonGiaNhap.Text = "";
            txtDonGiaBan.Text = "";
            picAnh.Image = null;
            txtGhiChu.Text = "";
            txtMaHang.Focus();
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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ban co muon xoa khong?", "Xoa mat hang",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dtBase.UpdateDB("Delete tblHang where MaHang='" + txtMaHang.Text + "'");
                dgvHang.DataSource = dtBase.ReadTable("select * from tblHang");
            }
            
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
            btnBoQua.Enabled = false;
            btnThem.Enabled = true;

            ResetValue();

        }

        private void cboChatLieu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            string sql = "SELECT * FROM tblhang where MaHang is not null ";
            if (txtMaHang.Text.Trim() != "")
                sql += " AND MaHang LIKE N'%" + txtMaHang.Text.Trim() + "%'";
            if (txtTenHang.Text.Trim() != "")
                sql += " AND TenHang LIKE N'%" + txtTenHang.Text.Trim() + "%'";
            if (cboChatLieu.Text.Trim() != "")
                sql += " AND MaChatLieu = '" + cboChatLieu.SelectedValue + "'";
            if (txtSoLuong.Text.Trim() != "")
                sql += " AND SoLuong = " + txtSoLuong.Text.Trim();
            if (txtDonGiaBan.Text.Trim() != "")
                sql += " AND DonGiaBan = " + txtDonGiaBan.Text.Trim();
            DataTable dthang = dtBase.ReadTable(sql);
            dgvHang.DataSource = dthang;
            if (dthang.Rows.Count < 0)
            {
                MessageBox.Show("Không có sản phẩm nào phù hợp với điều kiện tìm kiếm!", "Thông báo");
            }
            else
            {
                MessageBox.Show("Có " + dthang.Rows.Count + " sản phẩm được tìm thấy!", "Thông báo");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            DanhMuc.frmChatLieu f = new DanhMuc.frmChatLieu();

            f.ShowDialog();

            DataTable dtChatLieu = dtBase.ReadTable("Select * from tblChatLieu");
            ft.FillComBox(cboChatLieu, dtChatLieu, "TenChatLieu", "MaChatLieu");
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            //Bước 3 : Khai báo và khởi tạo các thành phần của đối tượng MICROSOFT.OFFICE.INTERPOP.EXCEL
            Excel.Application exApp = new Excel.Application();
            Excel.Workbook exBook = exApp.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);
            Excel.Worksheet exsheet = (Excel.Worksheet)exBook.Worksheets[1];
            Excel.Range tenTruong = (Excel.Range)exsheet.Cells[1, 1];
            //Bước 4: Định dạng file excel;
            tenTruong.Range["B2"].Font.Size = 25;
            tenTruong.Range["B2"].Font.Name = "Times New Roman";
            tenTruong.Range["B2"].Font.Color = Color.Red;
            tenTruong.Range["B2"].Value2 = "DANH SÁCH SẢN PHẨM";

            tenTruong.Range["A4:F4"].Font.Size = 13;
            tenTruong.Range["A4:F4"].Font.Name = "Times New Roman";
            tenTruong.Range["A4:F4"].Font.Color = Color.Black;
            tenTruong.Range["A4:F4"].Font.Bold = true;

            tenTruong.Range["A4"].Value = "Mã hàng";
            tenTruong.Range["B4"].Value = "Tên hàng";
            tenTruong.Range["C4"].Value = "Chất liệu";
            tenTruong.Range["D4"].Value = "Số lượng";
            tenTruong.Range["E4"].Value = "Đơn giá nhập";
            tenTruong.Range["F4"].Value = "Đơn giá bán";

            int hang = 5;
            for (int i = 0; i < dgvSanPham.Rows.Count - 1; i++)
            {
                tenTruong.Range["A" + hang.ToString()].Value = dgvSanPham.Rows[i].Cells[0].Value.ToString();
                tenTruong.Range["B" + hang.ToString()].Value = dgvSanPham.Rows[i].Cells[1].Value.ToString();
                tenTruong.Range["C" + hang.ToString()].Value = dgvSanPham.Rows[i].Cells[2].Value.ToString();
                tenTruong.Range["D" + hang.ToString()].Value = dgvSanPham.Rows[i].Cells[3].Value.ToString();
                tenTruong.Range["E" + hang.ToString()].Value = dgvSanPham.Rows[i].Cells[4].Value.ToString();
                tenTruong.Range["F" + hang.ToString()].Value = dgvSanPham.Rows[i].Cells[5].Value.ToString();
                hang++;
            }
            exsheet.Name = "DSSanPham";
            //Bước 5: Kích hoạt file excel;
            exBook.Activate();

            //Bước 6: lưu file;
            SaveFileDialog dlFile = new SaveFileDialog();
            if (dlFile.ShowDialog() == DialogResult.OK)
            {
                exBook.SaveAs(dlFile.FileName.ToString());
            }

            //Bước 7: Thoát khỏi ứng dụng;
            exApp.Quit();
        }
    }

}
