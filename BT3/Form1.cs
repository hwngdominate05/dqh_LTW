using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT3
{
    public partial class Form1 : Form
    {
        private void AddComboBoxDrinks()
        {
            comboBoxDrinks.Items.Add("Coca cola");
            comboBoxDrinks.Items.Add("Pepsi");
            comboBoxDrinks.Items.Add("Seven up");

        }
        private void AddComboBoxCount()
        {
            for (int i = 1; i <= 10; i++)
            {
                comboBoxCount.Items.Add(i.ToString());
            }

        }
        public Form1()
        {
            InitializeComponent();
            AddComboBoxCount();
            AddComboBoxDrinks();
        
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            comboBoxCount.SelectedIndex = -1;
            comboBoxDrinks.SelectedIndex = -1;
            radioButton1.Checked = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                textBox2.Text = "200";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                textBox2.Text = "100";
            }
        }
        private void TinhTien()
        {
            double don_gia = 0;
            double so_luong = 0;
            switch (comboBoxDrinks.SelectedItem.ToString())
            {
                case "Coca cola":
                    don_gia = 0.5;
                    break;
                case "Pepsi":
                    don_gia = 0.8;
                    break;
                case "Seven up":
                    don_gia = 1.0;
                    break;
            }
            if(comboBoxCount.SelectedItem != null)
            {
                so_luong = Convert.ToDouble(comboBoxCount.SelectedItem);
            }
            double tien = don_gia * so_luong;
            textBox3.Text = tien.ToString("0.00");

        }
        private void btnAddList_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên");
                return;
            }
            if(comboBoxDrinks.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa chọn đồ uống");
                return;
            }
            if(comboBoxCount.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa chọn số lượng");
                return;
            }
            if(radioButton1.Checked == false && radioButton2.Checked == false)
            {
                MessageBox.Show("Bạn phải chọn thời gian tour");
                return;
            }
            string item = textBox1.Text + " | ";

            if (radioButton1.Checked)
            {
                item += "Cả ngày";
            }
            else if (radioButton2.Checked)
            {
                item += "Nửa ngày";
            }

            if (comboBoxDrinks.SelectedItem != null)
            {
                item += " | " + comboBoxDrinks.SelectedItem.ToString();
            }

            if (comboBoxCount.SelectedItem != null)
            {
                item += " | Số lượng: " + comboBoxCount.SelectedItem.ToString();
            }

            item += " | Tiền: $" + textBox3.Text;

            listBox1.Items.Add(item);
        }

        private void comboBoxDrinks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxCount.SelectedIndex != -1)
            {
                TinhTien();

            }
        }

        private void comboBoxCount_SelectedIndexChanged(object sender, EventArgs e)
        {

            if(comboBoxDrinks.SelectedIndex != -1)
            {
                TinhTien();
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radioButton2.Checked = false;
            radioButton1.Checked = false;

        }
    }
}
