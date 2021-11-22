
namespace _3_GUI_PresentationLayer
{
    partial class Frm_BanHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_BanHang));
            this.label2 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.cboCamera = new System.Windows.Forms.ComboBox();
            this.Cammera = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbTongTien = new System.Windows.Forms.Label();
            this.btn_ThanhToan = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.grb_barcode = new System.Windows.Forms.GroupBox();
            this.btn_NhapLai = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.rdb_ChuaThanhToan = new System.Windows.Forms.RadioButton();
            this.rdb_DaThanhToan = new System.Windows.Forms.RadioButton();
            this.txt_soluong = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbDonGia = new System.Windows.Forms.Label();
            this.lb_Tongtien = new System.Windows.Forms.Label();
            this.lbSoLuong = new System.Windows.Forms.Label();
            this.lbTenSanPham = new System.Windows.Forms.Label();
            this.lbTrangThai = new System.Windows.Forms.Label();
            this.lbMahoadon = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_QuetMa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.grb_barcode.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 371);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "Barcode :";
            // 
            // btnStart
            // 
            this.btnStart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnStart.BackgroundImage")));
            this.btnStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnStart.Location = new System.Drawing.Point(990, 423);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(130, 40);
            this.btnStart.TabIndex = 16;
            this.btnStart.Text = "Bắt Đầu";
            this.btnStart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtBarcode
            // 
            this.txtBarcode.Location = new System.Drawing.Point(147, 368);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(998, 31);
            this.txtBarcode.TabIndex = 15;
            this.txtBarcode.TextChanged += new System.EventHandler(this.txtBarcode_TextChanged);
            this.txtBarcode.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBarcode_KeyUp);
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox.Location = new System.Drawing.Point(56, 74);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(1089, 285);
            this.pictureBox.TabIndex = 14;
            this.pictureBox.TabStop = false;
            // 
            // cboCamera
            // 
            this.cboCamera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCamera.FormattingEnabled = true;
            this.cboCamera.Location = new System.Drawing.Point(147, 26);
            this.cboCamera.Name = "cboCamera";
            this.cboCamera.Size = new System.Drawing.Size(998, 33);
            this.cboCamera.TabIndex = 13;
            // 
            // Cammera
            // 
            this.Cammera.AutoSize = true;
            this.Cammera.Location = new System.Drawing.Point(39, 29);
            this.Cammera.Name = "Cammera";
            this.Cammera.Size = new System.Drawing.Size(102, 25);
            this.Cammera.TabIndex = 12;
            this.Cammera.Text = "Cammera : ";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.Navy;
            this.label8.Location = new System.Drawing.Point(1145, 838);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 32);
            this.label8.TabIndex = 19;
            this.label8.Text = "Thành Tiền : ";
            // 
            // lbTongTien
            // 
            this.lbTongTien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTongTien.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTongTien.ForeColor = System.Drawing.Color.Red;
            this.lbTongTien.Location = new System.Drawing.Point(1304, 828);
            this.lbTongTien.Name = "lbTongTien";
            this.lbTongTien.Size = new System.Drawing.Size(185, 46);
            this.lbTongTien.TabIndex = 20;
            this.lbTongTien.Text = "Tổng Tiền ";
            this.lbTongTien.Click += new System.EventHandler(this.lbTongTien_Click);
            // 
            // btn_ThanhToan
            // 
            this.btn_ThanhToan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ThanhToan.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_ThanhToan.BackgroundImage")));
            this.btn_ThanhToan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_ThanhToan.ForeColor = System.Drawing.Color.Navy;
            this.btn_ThanhToan.Location = new System.Drawing.Point(1542, 821);
            this.btn_ThanhToan.Name = "btn_ThanhToan";
            this.btn_ThanhToan.Size = new System.Drawing.Size(162, 57);
            this.btn_ThanhToan.TabIndex = 23;
            this.btn_ThanhToan.Text = "Thanh Toán";
            this.btn_ThanhToan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ThanhToan.UseVisualStyleBackColor = true;
            this.btn_ThanhToan.Click += new System.EventHandler(this.btn_ThanhToan_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Location = new System.Drawing.Point(33, 197);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 40);
            this.button1.TabIndex = 26;
            this.button1.Text = "   Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // grb_barcode
            // 
            this.grb_barcode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grb_barcode.Controls.Add(this.pictureBox);
            this.grb_barcode.Controls.Add(this.Cammera);
            this.grb_barcode.Controls.Add(this.cboCamera);
            this.grb_barcode.Controls.Add(this.txtBarcode);
            this.grb_barcode.Controls.Add(this.btnStart);
            this.grb_barcode.Controls.Add(this.label2);
            this.grb_barcode.ForeColor = System.Drawing.Color.Navy;
            this.grb_barcode.Location = new System.Drawing.Point(50, 342);
            this.grb_barcode.Name = "grb_barcode";
            this.grb_barcode.Size = new System.Drawing.Size(1164, 480);
            this.grb_barcode.TabIndex = 27;
            this.grb_barcode.TabStop = false;
            this.grb_barcode.Text = "BarCode";
            this.grb_barcode.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btn_NhapLai
            // 
            this.btn_NhapLai.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_NhapLai.BackgroundImage")));
            this.btn_NhapLai.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_NhapLai.Location = new System.Drawing.Point(383, 197);
            this.btn_NhapLai.Name = "btn_NhapLai";
            this.btn_NhapLai.Size = new System.Drawing.Size(129, 40);
            this.btn_NhapLai.TabIndex = 26;
            this.btn_NhapLai.Text = "     Nhập Lại";
            this.btn_NhapLai.UseVisualStyleBackColor = true;
            this.btn_NhapLai.Click += new System.EventHandler(this.btn_NhapLai_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_sua.BackgroundImage")));
            this.btn_sua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_sua.Location = new System.Drawing.Point(208, 197);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(111, 40);
            this.btn_sua.TabIndex = 26;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // rdb_ChuaThanhToan
            // 
            this.rdb_ChuaThanhToan.AutoSize = true;
            this.rdb_ChuaThanhToan.Location = new System.Drawing.Point(323, 128);
            this.rdb_ChuaThanhToan.Name = "rdb_ChuaThanhToan";
            this.rdb_ChuaThanhToan.Size = new System.Drawing.Size(173, 29);
            this.rdb_ChuaThanhToan.TabIndex = 37;
            this.rdb_ChuaThanhToan.TabStop = true;
            this.rdb_ChuaThanhToan.Text = "Chưa Thanh Toán";
            this.rdb_ChuaThanhToan.UseVisualStyleBackColor = true;
            // 
            // rdb_DaThanhToan
            // 
            this.rdb_DaThanhToan.AutoSize = true;
            this.rdb_DaThanhToan.Location = new System.Drawing.Point(129, 130);
            this.rdb_DaThanhToan.Name = "rdb_DaThanhToan";
            this.rdb_DaThanhToan.Size = new System.Drawing.Size(154, 29);
            this.rdb_DaThanhToan.TabIndex = 38;
            this.rdb_DaThanhToan.TabStop = true;
            this.rdb_DaThanhToan.Text = "Đã Thanh Toán";
            this.rdb_DaThanhToan.UseVisualStyleBackColor = true;
            // 
            // txt_soluong
            // 
            this.txt_soluong.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_soluong.Location = new System.Drawing.Point(130, 74);
            this.txt_soluong.Name = "txt_soluong";
            this.txt_soluong.Size = new System.Drawing.Size(354, 37);
            this.txt_soluong.TabIndex = 35;
            this.txt_soluong.TextChanged += new System.EventHandler(this.txt_soluong_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 25);
            this.label5.TabIndex = 28;
            this.label5.Text = " Trạng Thái : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 25);
            this.label4.TabIndex = 29;
            this.label4.Text = "Sô Lượng : ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_NhapLai);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.txt_soluong);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.btn_sua);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.lbDonGia);
            this.groupBox3.Controls.Add(this.lb_Tongtien);
            this.groupBox3.Controls.Add(this.rdb_DaThanhToan);
            this.groupBox3.Controls.Add(this.lbSoLuong);
            this.groupBox3.Controls.Add(this.rdb_ChuaThanhToan);
            this.groupBox3.Controls.Add(this.lbTenSanPham);
            this.groupBox3.Controls.Add(this.lbTrangThai);
            this.groupBox3.Controls.Add(this.lbMahoadon);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(1220, 57);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(518, 765);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Hóa Đơn";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(18, 619);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(104, 25);
            this.label14.TabIndex = 0;
            this.label14.Text = "Tổng Tiền : ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(18, 567);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(103, 25);
            this.label13.TabIndex = 0;
            this.label13.Text = "Số Lượng : ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(18, 659);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(106, 25);
            this.label12.TabIndex = 0;
            this.label12.Text = "Trạng Thái : ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 514);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 25);
            this.label11.TabIndex = 0;
            this.label11.Text = "Đơn Giá : ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 459);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(136, 25);
            this.label10.TabIndex = 0;
            this.label10.Text = "Tên Sản Phẩm : ";
            // 
            // lbDonGia
            // 
            this.lbDonGia.AutoSize = true;
            this.lbDonGia.Location = new System.Drawing.Point(114, 514);
            this.lbDonGia.Name = "lbDonGia";
            this.lbDonGia.Size = new System.Drawing.Size(27, 25);
            this.lbDonGia.TabIndex = 0;
            this.lbDonGia.Text = "1 ";
            // 
            // lb_Tongtien
            // 
            this.lb_Tongtien.AutoSize = true;
            this.lb_Tongtien.Location = new System.Drawing.Point(138, 619);
            this.lb_Tongtien.Name = "lb_Tongtien";
            this.lb_Tongtien.Size = new System.Drawing.Size(27, 25);
            this.lb_Tongtien.TabIndex = 0;
            this.lb_Tongtien.Text = "1 ";
            // 
            // lbSoLuong
            // 
            this.lbSoLuong.AutoSize = true;
            this.lbSoLuong.Location = new System.Drawing.Point(138, 571);
            this.lbSoLuong.Name = "lbSoLuong";
            this.lbSoLuong.Size = new System.Drawing.Size(27, 25);
            this.lbSoLuong.TabIndex = 0;
            this.lbSoLuong.Text = "1 ";
            // 
            // lbTenSanPham
            // 
            this.lbTenSanPham.AutoSize = true;
            this.lbTenSanPham.Location = new System.Drawing.Point(171, 459);
            this.lbTenSanPham.Name = "lbTenSanPham";
            this.lbTenSanPham.Size = new System.Drawing.Size(27, 25);
            this.lbTenSanPham.TabIndex = 0;
            this.lbTenSanPham.Text = "1 ";
            // 
            // lbTrangThai
            // 
            this.lbTrangThai.AutoSize = true;
            this.lbTrangThai.Location = new System.Drawing.Point(130, 659);
            this.lbTrangThai.Name = "lbTrangThai";
            this.lbTrangThai.Size = new System.Drawing.Size(27, 25);
            this.lbTrangThai.TabIndex = 0;
            this.lbTrangThai.Text = "1 ";
            // 
            // lbMahoadon
            // 
            this.lbMahoadon.AutoSize = true;
            this.lbMahoadon.Location = new System.Drawing.Point(163, 404);
            this.lbMahoadon.Name = "lbMahoadon";
            this.lbMahoadon.Size = new System.Drawing.Size(27, 25);
            this.lbMahoadon.TabIndex = 0;
            this.lbMahoadon.Text = "1 ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 404);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 25);
            this.label9.TabIndex = 0;
            this.label9.Text = "Mã Hóa Đơn : ";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Location = new System.Drawing.Point(50, 57);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1164, 279);
            this.groupBox4.TabIndex = 30;
            this.groupBox4.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.AppWorkspace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 17);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1147, 256);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btn_QuetMa
            // 
            this.btn_QuetMa.Location = new System.Drawing.Point(286, 12);
            this.btn_QuetMa.Name = "btn_QuetMa";
            this.btn_QuetMa.Size = new System.Drawing.Size(126, 48);
            this.btn_QuetMa.TabIndex = 31;
            this.btn_QuetMa.Text = "Quét Mã ";
            this.btn_QuetMa.UseVisualStyleBackColor = true;
            this.btn_QuetMa.Click += new System.EventHandler(this.btn_QuetMa_Click);
            // 
            // Frm_BanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1750, 883);
            this.Controls.Add(this.btn_QuetMa);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.grb_barcode);
            this.Controls.Add(this.btn_ThanhToan);
            this.Controls.Add(this.lbTongTien);
            this.Controls.Add(this.label8);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Name = "Frm_BanHang";
            this.Text = "Bán Hàng ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_BanHang_FormClosing);
            this.Load += new System.EventHandler(this.Frm_BanHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.grb_barcode.ResumeLayout(false);
            this.grb_barcode.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.ComboBox cboCamera;
        private System.Windows.Forms.Label Cammera;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbTongTien;
        private System.Windows.Forms.Button btn_ThanhToan;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox grb_barcode;
        private System.Windows.Forms.Button btn_NhapLai;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.RadioButton rdb_ChuaThanhToan;
        private System.Windows.Forms.RadioButton rdb_DaThanhToan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_soluong;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbDonGia;
        private System.Windows.Forms.Label lb_Tongtien;
        private System.Windows.Forms.Label lbSoLuong;
        private System.Windows.Forms.Label lbTenSanPham;
        private System.Windows.Forms.Label lbTrangThai;
        private System.Windows.Forms.Label lbMahoadon;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_QuetMa;
    }
}