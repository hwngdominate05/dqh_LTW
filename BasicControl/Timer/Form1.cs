using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
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
        private void timer1_Tick(object sender, EventArgs e)
        {
            int m, s;
            m = int.Parse(textBox1.Text);
            s = int.Parse(textBox2.Text);
            if (s > 0 && s <= 59)
                s = s - 1;
            else
            {
                if(m > 0 && s == 0)
                {
                    s = 59;
                    m = m - 1;
                }
                if(m == 0 && s == 0)
                {
                    timer1.Stop();
                    MessageBox.Show("Hết giờ");
                }
            }
            textBox1.Text = m.ToString();
            textBox2.Text = s.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}
