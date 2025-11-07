namespace Bai1_Thuchanh
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lvMonHoc = new System.Windows.Forms.ListView();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtDiem = new System.Windows.Forms.TextBox();
            this.txtSoTinChi = new System.Windows.Forms.TextBox();
            this.cboMonHoc = new System.Windows.Forms.ComboBox();
            this.diem = new System.Windows.Forms.Label();
            this.soTC = new System.Windows.Forms.Label();
            this.tenMH = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tongTC = new System.Windows.Forms.Label();
            this.tongDiem = new System.Windows.Forms.Label();
            this.diemTB = new System.Windows.Forms.Label();
            this.txtTongTinChi = new System.Windows.Forms.TextBox();
            this.txtTongDiem = new System.Windows.Forms.TextBox();
            this.txtDiemTB = new System.Windows.Forms.TextBox();
            this.btnTinh = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.txtDiem);
            this.groupBox1.Controls.Add(this.txtSoTinChi);
            this.groupBox1.Controls.Add(this.cboMonHoc);
            this.groupBox1.Controls.Add(this.diem);
            this.groupBox1.Controls.Add(this.soTC);
            this.groupBox1.Controls.Add(this.tenMH);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(344, 425);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin điểm sinh viên";
            // 
            // lvMonHoc
            // 
            this.lvMonHoc.GridLines = true;
            this.lvMonHoc.HideSelection = false;
            this.lvMonHoc.Location = new System.Drawing.Point(6, 32);
            this.lvMonHoc.Name = "lvMonHoc";
            this.lvMonHoc.Size = new System.Drawing.Size(1114, 167);
            this.lvMonHoc.TabIndex = 0;
            this.lvMonHoc.UseCompatibleStateImageBehavior = false;
            this.lvMonHoc.SelectedIndexChanged += new System.EventHandler(this.lvMonHoc_SelectedIndexChanged);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(67, 270);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(165, 45);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm vào DS";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtDiem
            // 
            this.txtDiem.Location = new System.Drawing.Point(106, 200);
            this.txtDiem.Name = "txtDiem";
            this.txtDiem.Size = new System.Drawing.Size(183, 22);
            this.txtDiem.TabIndex = 5;
            // 
            // txtSoTinChi
            // 
            this.txtSoTinChi.Location = new System.Drawing.Point(106, 139);
            this.txtSoTinChi.Name = "txtSoTinChi";
            this.txtSoTinChi.Size = new System.Drawing.Size(183, 22);
            this.txtSoTinChi.TabIndex = 4;
            // 
            // cboMonHoc
            // 
            this.cboMonHoc.FormattingEnabled = true;
            this.cboMonHoc.Location = new System.Drawing.Point(19, 91);
            this.cboMonHoc.Name = "cboMonHoc";
            this.cboMonHoc.Size = new System.Drawing.Size(270, 24);
            this.cboMonHoc.TabIndex = 3;
            this.cboMonHoc.SelectedIndexChanged += new System.EventHandler(this.cboMonHoc_SelectedIndexChanged);
            // 
            // diem
            // 
            this.diem.AutoSize = true;
            this.diem.Location = new System.Drawing.Point(16, 200);
            this.diem.Name = "diem";
            this.diem.Size = new System.Drawing.Size(38, 16);
            this.diem.TabIndex = 2;
            this.diem.Text = "Điểm";
            // 
            // soTC
            // 
            this.soTC.AutoSize = true;
            this.soTC.Location = new System.Drawing.Point(16, 142);
            this.soTC.Name = "soTC";
            this.soTC.Size = new System.Drawing.Size(60, 16);
            this.soTC.TabIndex = 1;
            this.soTC.Text = "Số tín chỉ";
            // 
            // tenMH
            // 
            this.tenMH.AutoSize = true;
            this.tenMH.Location = new System.Drawing.Point(16, 50);
            this.tenMH.Name = "tenMH";
            this.tenMH.Size = new System.Drawing.Size(85, 16);
            this.tenMH.TabIndex = 0;
            this.tenMH.Text = "Tên môn học";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lvMonHoc);
            this.groupBox2.Location = new System.Drawing.Point(357, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1155, 235);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách điểm môn học";
            // 
            // tongTC
            // 
            this.tongTC.AutoSize = true;
            this.tongTC.Location = new System.Drawing.Point(395, 277);
            this.tongTC.Name = "tongTC";
            this.tongTC.Size = new System.Drawing.Size(93, 16);
            this.tongTC.TabIndex = 3;
            this.tongTC.Text = "Tổng số tín chỉ";
            // 
            // tongDiem
            // 
            this.tongDiem.AutoSize = true;
            this.tongDiem.Location = new System.Drawing.Point(912, 280);
            this.tongDiem.Name = "tongDiem";
            this.tongDiem.Size = new System.Drawing.Size(72, 16);
            this.tongDiem.TabIndex = 4;
            this.tongDiem.Text = "Tổng điểm";
            // 
            // diemTB
            // 
            this.diemTB.AutoSize = true;
            this.diemTB.Location = new System.Drawing.Point(395, 343);
            this.diemTB.Name = "diemTB";
            this.diemTB.Size = new System.Drawing.Size(98, 16);
            this.diemTB.TabIndex = 5;
            this.diemTB.Text = "Điểm trung bình";
            // 
            // txtTongTinChi
            // 
            this.txtTongTinChi.Location = new System.Drawing.Point(528, 274);
            this.txtTongTinChi.Name = "txtTongTinChi";
            this.txtTongTinChi.Size = new System.Drawing.Size(281, 22);
            this.txtTongTinChi.TabIndex = 6;
            // 
            // txtTongDiem
            // 
            this.txtTongDiem.Location = new System.Drawing.Point(1091, 274);
            this.txtTongDiem.Name = "txtTongDiem";
            this.txtTongDiem.Size = new System.Drawing.Size(275, 22);
            this.txtTongDiem.TabIndex = 7;
            // 
            // txtDiemTB
            // 
            this.txtDiemTB.Location = new System.Drawing.Point(528, 340);
            this.txtDiemTB.Name = "txtDiemTB";
            this.txtDiemTB.Size = new System.Drawing.Size(472, 22);
            this.txtDiemTB.TabIndex = 8;
            // 
            // btnTinh
            // 
            this.btnTinh.Location = new System.Drawing.Point(602, 384);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(162, 45);
            this.btnTinh.TabIndex = 7;
            this.btnTinh.Text = "Tính";
            this.btnTinh.UseVisualStyleBackColor = true;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(977, 384);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(170, 45);
            this.btnThoat.TabIndex = 9;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1524, 450);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.txtDiemTB);
            this.Controls.Add(this.txtTongDiem);
            this.Controls.Add(this.txtTongTinChi);
            this.Controls.Add(this.diemTB);
            this.Controls.Add(this.tongDiem);
            this.Controls.Add(this.tongTC);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtDiem;
        private System.Windows.Forms.TextBox txtSoTinChi;
        private System.Windows.Forms.ComboBox cboMonHoc;
        private System.Windows.Forms.Label diem;
        private System.Windows.Forms.Label soTC;
        private System.Windows.Forms.Label tenMH;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView lvMonHoc;
        private System.Windows.Forms.Label tongTC;
        private System.Windows.Forms.Label tongDiem;
        private System.Windows.Forms.Label diemTB;
        private System.Windows.Forms.TextBox txtTongTinChi;
        private System.Windows.Forms.TextBox txtTongDiem;
        private System.Windows.Forms.TextBox txtDiemTB;
        private System.Windows.Forms.Button btnTinh;
        private System.Windows.Forms.Button btnThoat;
    }
}

