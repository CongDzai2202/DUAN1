﻿
namespace _3_GUI_PresentationLayer
{
    partial class Frm_NhapKho
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
            this.cbx_maNCC = new System.Windows.Forms.ComboBox();
            this.cbx_tenSP = new System.Windows.Forms.ComboBox();
            this.cbx_tenNCC = new System.Windows.Forms.ComboBox();
            this.cbx_maSP = new System.Windows.Forms.ComboBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnNhapLai = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dtp_NgayNhap = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_DonGia = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_SoLuong = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_maPhieu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.rdbt_TenSanPham = new System.Windows.Forms.RadioButton();
            this.rdbt_MaSanPham = new System.Windows.Forms.RadioButton();
            this.txt_TimKiemtt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dgv_nhapKho = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nhapKho)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbx_maNCC);
            this.groupBox1.Controls.Add(this.cbx_tenSP);
            this.groupBox1.Controls.Add(this.cbx_tenNCC);
            this.groupBox1.Controls.Add(this.cbx_maSP);
            this.groupBox1.Controls.Add(this.btnThoat);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnLuu);
            this.groupBox1.Controls.Add(this.btnNhapLai);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.dtp_NgayNhap);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txt_DonGia);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_SoLuong);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_maPhieu);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(649, 334);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Khung nhập liệu";
            // 
            // cbx_maNCC
            // 
            this.cbx_maNCC.FormattingEnabled = true;
            this.cbx_maNCC.Location = new System.Drawing.Point(450, 96);
            this.cbx_maNCC.Name = "cbx_maNCC";
            this.cbx_maNCC.Size = new System.Drawing.Size(179, 31);
            this.cbx_maNCC.TabIndex = 33;
            // 
            // cbx_tenSP
            // 
            this.cbx_tenSP.FormattingEnabled = true;
            this.cbx_tenSP.Location = new System.Drawing.Point(134, 96);
            this.cbx_tenSP.Name = "cbx_tenSP";
            this.cbx_tenSP.Size = new System.Drawing.Size(179, 31);
            this.cbx_tenSP.TabIndex = 32;
            // 
            // cbx_tenNCC
            // 
            this.cbx_tenNCC.FormattingEnabled = true;
            this.cbx_tenNCC.Location = new System.Drawing.Point(134, 149);
            this.cbx_tenNCC.Name = "cbx_tenNCC";
            this.cbx_tenNCC.Size = new System.Drawing.Size(179, 31);
            this.cbx_tenNCC.TabIndex = 31;
            // 
            // cbx_maSP
            // 
            this.cbx_maSP.FormattingEnabled = true;
            this.cbx_maSP.Location = new System.Drawing.Point(450, 42);
            this.cbx_maSP.Name = "cbx_maSP";
            this.cbx_maSP.Size = new System.Drawing.Size(179, 31);
            this.cbx_maSP.TabIndex = 30;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(529, 272);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(111, 44);
            this.btnThoat.TabIndex = 29;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(401, 272);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(111, 44);
            this.btnSua.TabIndex = 28;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(273, 272);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(111, 44);
            this.btnLuu.TabIndex = 27;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnNhapLai
            // 
            this.btnNhapLai.Location = new System.Drawing.Point(145, 272);
            this.btnNhapLai.Name = "btnNhapLai";
            this.btnNhapLai.Size = new System.Drawing.Size(111, 44);
            this.btnNhapLai.TabIndex = 26;
            this.btnNhapLai.Text = "Nhập lại";
            this.btnNhapLai.UseVisualStyleBackColor = true;
            this.btnNhapLai.Click += new System.EventHandler(this.btnNhapLai_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(17, 272);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(111, 44);
            this.btnThem.TabIndex = 25;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dtp_NgayNhap
            // 
            this.dtp_NgayNhap.CustomFormat = "dd/MM/yyyy";
            this.dtp_NgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_NgayNhap.Location = new System.Drawing.Point(450, 207);
            this.dtp_NgayNhap.Name = "dtp_NgayNhap";
            this.dtp_NgayNhap.Size = new System.Drawing.Size(179, 30);
            this.dtp_NgayNhap.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(337, 211);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 21);
            this.label10.TabIndex = 18;
            this.label10.Text = "Ngày nhập:";
            // 
            // txt_DonGia
            // 
            this.txt_DonGia.Location = new System.Drawing.Point(134, 207);
            this.txt_DonGia.Name = "txt_DonGia";
            this.txt_DonGia.Size = new System.Drawing.Size(179, 30);
            this.txt_DonGia.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(17, 211);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 21);
            this.label7.TabIndex = 12;
            this.label7.Text = "Đơn giá:";
            // 
            // txt_SoLuong
            // 
            this.txt_SoLuong.Location = new System.Drawing.Point(450, 150);
            this.txt_SoLuong.Name = "txt_SoLuong";
            this.txt_SoLuong.Size = new System.Drawing.Size(179, 30);
            this.txt_SoLuong.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(337, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 21);
            this.label6.TabIndex = 10;
            this.label6.Text = "Số lượng:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(337, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "Mã NCC:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(19, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tên NCC:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(17, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên sản phẩm:";
            // 
            // txt_maPhieu
            // 
            this.txt_maPhieu.Location = new System.Drawing.Point(134, 43);
            this.txt_maPhieu.Name = "txt_maPhieu";
            this.txt_maPhieu.Size = new System.Drawing.Size(179, 30);
            this.txt_maPhieu.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(337, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã sản phẩm:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(17, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã phiếu:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_TimKiem);
            this.groupBox2.Controls.Add(this.rdbt_TenSanPham);
            this.groupBox2.Controls.Add(this.rdbt_MaSanPham);
            this.groupBox2.Controls.Add(this.txt_TimKiemtt);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(652, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(264, 334);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm thông tin";
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_TimKiem.Location = new System.Drawing.Point(146, 272);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(111, 44);
            this.btn_TimKiem.TabIndex = 30;
            this.btn_TimKiem.Text = "Tìm kiếm";
            this.btn_TimKiem.UseVisualStyleBackColor = true;
            // 
            // rdbt_TenSanPham
            // 
            this.rdbt_TenSanPham.AutoSize = true;
            this.rdbt_TenSanPham.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdbt_TenSanPham.Location = new System.Drawing.Point(24, 200);
            this.rdbt_TenSanPham.Name = "rdbt_TenSanPham";
            this.rdbt_TenSanPham.Size = new System.Drawing.Size(190, 25);
            this.rdbt_TenSanPham.TabIndex = 23;
            this.rdbt_TenSanPham.Text = "Tìm theo tên sản phẩm:";
            this.rdbt_TenSanPham.UseVisualStyleBackColor = true;
            // 
            // rdbt_MaSanPham
            // 
            this.rdbt_MaSanPham.AutoSize = true;
            this.rdbt_MaSanPham.Checked = true;
            this.rdbt_MaSanPham.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdbt_MaSanPham.Location = new System.Drawing.Point(24, 149);
            this.rdbt_MaSanPham.Name = "rdbt_MaSanPham";
            this.rdbt_MaSanPham.Size = new System.Drawing.Size(190, 25);
            this.rdbt_MaSanPham.TabIndex = 22;
            this.rdbt_MaSanPham.TabStop = true;
            this.rdbt_MaSanPham.Text = "Tìm theo mã sản phẩm:";
            this.rdbt_MaSanPham.UseVisualStyleBackColor = true;
            // 
            // txt_TimKiemtt
            // 
            this.txt_TimKiemtt.Location = new System.Drawing.Point(23, 97);
            this.txt_TimKiemtt.Name = "txt_TimKiemtt";
            this.txt_TimKiemtt.Size = new System.Drawing.Size(234, 30);
            this.txt_TimKiemtt.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(24, 42);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(200, 25);
            this.label11.TabIndex = 20;
            this.label11.Text = "Nhập thông tin cần tìm:";
            // 
            // dgv_nhapKho
            // 
            this.dgv_nhapKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_nhapKho.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_nhapKho.Location = new System.Drawing.Point(0, 341);
            this.dgv_nhapKho.Name = "dgv_nhapKho";
            this.dgv_nhapKho.RowTemplate.Height = 25;
            this.dgv_nhapKho.Size = new System.Drawing.Size(921, 244);
            this.dgv_nhapKho.TabIndex = 2;
            this.dgv_nhapKho.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_nhapKho_CellClick);
            // 
            // Frm_NhapKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 585);
            this.Controls.Add(this.dgv_nhapKho);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "Frm_NhapKho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_NhapKho";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nhapKho)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtp_NgayNhap;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_DonGia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_SoLuong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_maPhieu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdbt_TenSanPham;
        private System.Windows.Forms.RadioButton rdbt_MaSanPham;
        private System.Windows.Forms.TextBox txt_TimKiemtt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnNhapLai;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.DataGridView dgv_nhapKho;
        private System.Windows.Forms.ComboBox cbx_maNCC;
        private System.Windows.Forms.ComboBox cbx_tenSP;
        private System.Windows.Forms.ComboBox cbx_tenNCC;
        private System.Windows.Forms.ComboBox cbx_maSP;
    }
}