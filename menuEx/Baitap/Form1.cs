using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baitap
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            FontDialog font = new FontDialog();
            font.ShowColor = true;
            if(font.ShowDialog() == DialogResult.OK)
            {
                rTxtBox.SelectionFont = font.Font;
                rTxtBox.SelectionColor = font.Color;
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "RTF Files (*.rtf)";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    rTxtBox.SaveFile(saveFileDialog.FileName, RichTextBoxStreamType.RichText);
                }

            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "RTF Files (*.rtf)";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                rTxtBox.LoadFile(openFileDialog.FileName, RichTextBoxStreamType.RichText);
            }
        }
    }
}
