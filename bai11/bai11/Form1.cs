using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listBox1.SelectedItems != null)
            {
                string item = listBox1.SelectedItems.ToString();
                
                if (listBox1.Items.Contains(item))
                {
                    DialogResult r = MessageBox.Show($"Bạn có muốn xóa {item} không?",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    listBox1.Items.Remove(item);
                }
            }
            
        }

        private void listBox2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listBox1.SelectedItems != null)
            {
                var item = listBox2.SelectedItems.ToString();
                
                if (listBox2.Items.Contains(item))
                {
                    MessageBox.Show($"Bạn đã chọn mua cuốn {item} rồi!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    listBox2.Items.Add(item);
                }
            }
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            if(listBox1.SelectedItems != null)
            {
                string item = listBox1.SelectedItems.ToString();
                DialogResult r = MessageBox.Show(
                    "Bạn có muốn xóa mặt hàng " { item }, "Không","Xác nhận",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    listBox1.Items.Remove(item);
                }
        }
    }
}
