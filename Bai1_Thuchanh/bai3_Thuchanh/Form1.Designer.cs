namespace bai3_Thuchanh
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.hoTen = new System.Windows.Forms.Label();
            this.giaDuThuyen = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.doUong = new System.Windows.Forms.Label();
            this.soLuong = new System.Windows.Forms.Label();
            this.tien = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtGiaDuThuyen = new System.Windows.Forms.TextBox();
            this.txtTien = new System.Windows.Forms.TextBox();
            this.rdoCaNgay = new System.Windows.Forms.RadioButton();
            this.rdoNuaNgay = new System.Windows.Forms.RadioButton();
            this.btnThemDS = new System.Windows.Forms.Button();
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.lstKhachHang = new System.Windows.Forms.ListBox();
            this.cboDoUong = new System.Windows.Forms.ComboBox();
            this.cboSoLuong = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboSoLuong);
            this.groupBox1.Controls.Add(this.cboDoUong);
            this.groupBox1.Controls.Add(this.btnThemMoi);
            this.groupBox1.Controls.Add(this.btnThemDS);
            this.groupBox1.Controls.Add(this.rdoNuaNgay);
            this.groupBox1.Controls.Add(this.rdoCaNgay);
            this.groupBox1.Controls.Add(this.txtTien);
            this.groupBox1.Controls.Add(this.txtGiaDuThuyen);
            this.groupBox1.Controls.Add(this.txtHoTen);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tien);
            this.groupBox1.Controls.Add(this.soLuong);
            this.groupBox1.Controls.Add(this.doUong);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.hoTen);
            this.groupBox1.Controls.Add(this.giaDuThuyen);
            this.groupBox1.Location = new System.Drawing.Point(13, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(317, 289);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập thông tin khách hàng đặt Tour";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstKhachHang);
            this.groupBox2.Location = new System.Drawing.Point(336, 84);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(435, 266);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách khách hàng đặt Tour";
            // 
            // hoTen
            // 
            this.hoTen.AutoSize = true;
            this.hoTen.Location = new System.Drawing.Point(16, 40);
            this.hoTen.Name = "hoTen";
            this.hoTen.Size = new System.Drawing.Size(52, 16);
            this.hoTen.TabIndex = 2;
            this.hoTen.Text = "Họ Tên";
            // 
            // giaDuThuyen
            // 
            this.giaDuThuyen.AutoSize = true;
            this.giaDuThuyen.Location = new System.Drawing.Point(14, 115);
            this.giaDuThuyen.Name = "giaDuThuyen";
            this.giaDuThuyen.Size = new System.Drawing.Size(96, 16);
            this.giaDuThuyen.TabIndex = 0;
            this.giaDuThuyen.Text = "Giá Du Thuyền";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(259, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "$";
            // 
            // doUong
            // 
            this.doUong.AutoSize = true;
            this.doUong.Location = new System.Drawing.Point(14, 161);
            this.doUong.Name = "doUong";
            this.doUong.Size = new System.Drawing.Size(94, 16);
            this.doUong.TabIndex = 4;
            this.doUong.Text = "Chọn Đồ Uống";
            // 
            // soLuong
            // 
            this.soLuong.AutoSize = true;
            this.soLuong.Location = new System.Drawing.Point(133, 161);
            this.soLuong.Name = "soLuong";
            this.soLuong.Size = new System.Drawing.Size(64, 16);
            this.soLuong.TabIndex = 5;
            this.soLuong.Text = "Số Lượng";
            // 
            // tien
            // 
            this.tien.AutoSize = true;
            this.tien.Location = new System.Drawing.Point(239, 161);
            this.tien.Name = "tien";
            this.tien.Size = new System.Drawing.Size(34, 16);
            this.tien.TabIndex = 6;
            this.tien.Text = "Tiền";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(297, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "$";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(83, 40);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(166, 22);
            this.txtHoTen.TabIndex = 8;
            // 
            // txtGiaDuThuyen
            // 
            this.txtGiaDuThuyen.Location = new System.Drawing.Point(116, 112);
            this.txtGiaDuThuyen.Name = "txtGiaDuThuyen";
            this.txtGiaDuThuyen.Size = new System.Drawing.Size(133, 22);
            this.txtGiaDuThuyen.TabIndex = 9;
            // 
            // txtTien
            // 
            this.txtTien.Location = new System.Drawing.Point(222, 192);
            this.txtTien.Name = "txtTien";
            this.txtTien.Size = new System.Drawing.Size(69, 22);
            this.txtTien.TabIndex = 10;
            // 
            // rdoCaNgay
            // 
            this.rdoCaNgay.AutoSize = true;
            this.rdoCaNgay.Location = new System.Drawing.Point(19, 78);
            this.rdoCaNgay.Name = "rdoCaNgay";
            this.rdoCaNgay.Size = new System.Drawing.Size(78, 20);
            this.rdoCaNgay.TabIndex = 0;
            this.rdoCaNgay.Text = "Cả ngày";
            this.rdoCaNgay.UseVisualStyleBackColor = true;
            // 
            // rdoNuaNgay
            // 
            this.rdoNuaNgay.AutoSize = true;
            this.rdoNuaNgay.Location = new System.Drawing.Point(121, 78);
            this.rdoNuaNgay.Name = "rdoNuaNgay";
            this.rdoNuaNgay.Size = new System.Drawing.Size(86, 20);
            this.rdoNuaNgay.TabIndex = 11;
            this.rdoNuaNgay.Text = "Nửa ngày";
            this.rdoNuaNgay.UseVisualStyleBackColor = true;
            // 
            // btnThemDS
            // 
            this.btnThemDS.Location = new System.Drawing.Point(35, 234);
            this.btnThemDS.Name = "btnThemDS";
            this.btnThemDS.Size = new System.Drawing.Size(113, 33);
            this.btnThemDS.TabIndex = 12;
            this.btnThemDS.Text = "Thêm vào DS";
            this.btnThemDS.UseVisualStyleBackColor = true;
            this.btnThemDS.Click += new System.EventHandler(this.btnThemDS_Click);
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Location = new System.Drawing.Point(167, 234);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(106, 33);
            this.btnThemMoi.TabIndex = 13;
            this.btnThemMoi.Text = "Thêm mới";
            this.btnThemMoi.UseVisualStyleBackColor = true;
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(560, 387);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(133, 37);
            this.btnThoat.TabIndex = 14;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // lstKhachHang
            // 
            this.lstKhachHang.FormattingEnabled = true;
            this.lstKhachHang.ItemHeight = 16;
            this.lstKhachHang.Location = new System.Drawing.Point(30, 45);
            this.lstKhachHang.Name = "lstKhachHang";
            this.lstKhachHang.Size = new System.Drawing.Size(372, 180);
            this.lstKhachHang.TabIndex = 0;
            // 
            // cboDoUong
            // 
            this.cboDoUong.FormattingEnabled = true;
            this.cboDoUong.Location = new System.Drawing.Point(19, 192);
            this.cboDoUong.Name = "cboDoUong";
            this.cboDoUong.Size = new System.Drawing.Size(91, 24);
            this.cboDoUong.TabIndex = 14;
            // 
            // cboSoLuong
            // 
            this.cboSoLuong.FormattingEnabled = true;
            this.cboSoLuong.Location = new System.Drawing.Point(131, 192);
            this.cboSoLuong.Name = "cboSoLuong";
            this.cboSoLuong.Size = new System.Drawing.Size(76, 24);
            this.cboSoLuong.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTien;
        private System.Windows.Forms.TextBox txtGiaDuThuyen;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label tien;
        private System.Windows.Forms.Label soLuong;
        private System.Windows.Forms.Label doUong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label hoTen;
        private System.Windows.Forms.Label giaDuThuyen;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdoCaNgay;
        private System.Windows.Forms.ComboBox cboSoLuong;
        private System.Windows.Forms.ComboBox cboDoUong;
        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.Button btnThemDS;
        private System.Windows.Forms.RadioButton rdoNuaNgay;
        private System.Windows.Forms.ListBox lstKhachHang;
        private System.Windows.Forms.Button btnThoat;
    }
}

