using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBanHang
{
    public partial class Form1 : Form
    {
        Classes.ConnectDataBase dtBase = new Classes.ConnectDataBase();

        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dtKhach = dtBase.ReadData("Select * from tblKhachHang");
            dataGridView2.DataSource = dtKhach; //data grid view
            dataGridView2.Columns[0].HeaderText = "Mã khách";
            dataGridView2.Columns[1].HeaderText = "Tên khách";
            dataGridView2.Columns[2].HeaderText = "Số ĐT";
            dataGridView2.Columns[3].HeaderText = "Địa chỉ";
            dataGridView2.Columns[1].Width = 200;
            dataGridView2.Columns[2].Width = 500;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //Kiểm tra nhập đủ dữ liệu
            if (txtMaKhach.Text.Trim() == " ")
            {
                MessageBox.Show("Bạn phải nhập mã khách");
                txtMaKhach.Focus();
                return;
            }
            if (txtTenKhach.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập tên");
                txtTenKhach.Focus();
                return;
            }


            //Kiểm tra trùng mã
            DataTable dtCheckCode = dtBase.ReadData("Select * form tblKhachHang where " +
                "MaKhach ='" + txtMaKhach.Text + "'");
            if (dtCheckCode.Rows.Count > 0)
            {
                MessageBox.Show("Mã khách đã có, mời bạn nhập mã khác");
                txtMaKhach.Focus();
                return;
            }
        //Thêm dữ liệu vào sql
        dtBase.UpdateData("insert into tblKhachHang values('"+txtMaKhach.Text+
            "',N"+txtTenKhach.Text+"','"+txtSoDT.Text+"',N'"+txtDiaChi.Text+"')");
        //Hiển thị lại dữ liệu
        Form1_Load(sender, e);
        //Reset form
        ResetValue();

    }
    void ResetValue()
        {
            txtMaKhach.Text = "";
            txtTenKhach.Text = "";
            txtSoDT.Text = "";
            txtDiaChi.Text = "";
            txtMaKhach.Focus();
            txtTenKhach.Focus();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaKhach.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            txtTenKhach.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            txtSoDT.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            txtDiaChi.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
        }
    }
}
