
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.grb_SanPham = new System.Windows.Forms.GroupBox();
            this.dgidSanPham = new System.Windows.Forms.DataGridView();
            this.Hoa = new System.Windows.Forms.GroupBox();
            this.lv_HoaDon = new System.Windows.Forms.ListView();
            this.btn_QuetMa = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.nbr_SoLuong = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lbDonGia = new System.Windows.Forms.Label();
            this.lb_Tongtien = new System.Windows.Forms.Label();
            this.lbSoLuong = new System.Windows.Forms.Label();
            this.lbTenSanPham = new System.Windows.Forms.Label();
            this.lbTrangThai = new System.Windows.Forms.Label();
            this.lbMahoadon = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.grb_barcode = new System.Windows.Forms.GroupBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.Cammera = new System.Windows.Forms.Label();
            this.cboCamera = new System.Windows.Forms.ComboBox();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_ThanhToan = new System.Windows.Forms.Button();
            this.lbTongTien = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.grb_SanPham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgidSanPham)).BeginInit();
            this.Hoa.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbr_SoLuong)).BeginInit();
            this.grb_barcode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1869, 1050);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.grb_SanPham);
            this.tabPage1.Controls.Add(this.Hoa);
            this.tabPage1.Controls.Add(this.btn_QuetMa);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.grb_barcode);
            this.tabPage1.Controls.Add(this.btn_ThanhToan);
            this.tabPage1.Controls.Add(this.lbTongTien);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1861, 1012);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Hóa Đơn 1 ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // grb_SanPham
            // 
            this.grb_SanPham.Controls.Add(this.dgidSanPham);
            this.grb_SanPham.Location = new System.Drawing.Point(27, 417);
            this.grb_SanPham.Name = "grb_SanPham";
            this.grb_SanPham.Size = new System.Drawing.Size(1028, 487);
            this.grb_SanPham.TabIndex = 18;
            this.grb_SanPham.TabStop = false;
            this.grb_SanPham.Text = "Thông Tin Sản Phẩm ";
            // 
            // dgidSanPham
            // 
            this.dgidSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgidSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgidSanPham.Location = new System.Drawing.Point(7, 43);
            this.dgidSanPham.Name = "dgidSanPham";
            this.dgidSanPham.RowHeadersWidth = 62;
            this.dgidSanPham.RowTemplate.Height = 33;
            this.dgidSanPham.Size = new System.Drawing.Size(996, 323);
            this.dgidSanPham.TabIndex = 0;
            this.dgidSanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgidSanPham_CellClick);
            // 
            // Hoa
            // 
            this.Hoa.Controls.Add(this.lv_HoaDon);
            this.Hoa.Location = new System.Drawing.Point(1463, 0);
            this.Hoa.Name = "Hoa";
            this.Hoa.Size = new System.Drawing.Size(390, 896);
            this.Hoa.TabIndex = 39;
            this.Hoa.TabStop = false;
            this.Hoa.Text = "Hóa Đơn Chưa Thanh Toán";
            this.Hoa.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // lv_HoaDon
            // 
            this.lv_HoaDon.HideSelection = false;
            this.lv_HoaDon.Location = new System.Drawing.Point(20, 43);
            this.lv_HoaDon.Name = "lv_HoaDon";
            this.lv_HoaDon.Size = new System.Drawing.Size(344, 835);
            this.lv_HoaDon.TabIndex = 0;
            this.lv_HoaDon.UseCompatibleStateImageBehavior = false;
            // 
            // btn_QuetMa
            // 
            this.btn_QuetMa.Location = new System.Drawing.Point(27, 298);
            this.btn_QuetMa.Name = "btn_QuetMa";
            this.btn_QuetMa.Size = new System.Drawing.Size(126, 48);
            this.btn_QuetMa.TabIndex = 38;
            this.btn_QuetMa.Text = "Quét Mã ";
            this.btn_QuetMa.UseVisualStyleBackColor = true;
            this.btn_QuetMa.Click += new System.EventHandler(this.btn_QuetMa_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Location = new System.Drawing.Point(27, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1021, 285);
            this.groupBox4.TabIndex = 37;
            this.groupBox4.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.AppWorkspace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1009, 260);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.nbr_SoLuong);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.lbDonGia);
            this.groupBox3.Controls.Add(this.lb_Tongtien);
            this.groupBox3.Controls.Add(this.lbSoLuong);
            this.groupBox3.Controls.Add(this.lbTenSanPham);
            this.groupBox3.Controls.Add(this.lbTrangThai);
            this.groupBox3.Controls.Add(this.lbMahoadon);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(1068, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(375, 890);
            this.groupBox3.TabIndex = 36;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Hóa Đơn";
            // 
            // nbr_SoLuong
            // 
            this.nbr_SoLuong.Location = new System.Drawing.Point(123, 48);
            this.nbr_SoLuong.Name = "nbr_SoLuong";
            this.nbr_SoLuong.Size = new System.Drawing.Size(231, 31);
            this.nbr_SoLuong.TabIndex = 28;
            this.nbr_SoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 25);
            this.label1.TabIndex = 27;
            this.label1.Text = "Số Lượng : ";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(38, 471);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(104, 25);
            this.label14.TabIndex = 0;
            this.label14.Text = "Tổng Tiền : ";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(38, 419);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(103, 25);
            this.label13.TabIndex = 0;
            this.label13.Text = "Số Lượng : ";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(38, 511);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(106, 25);
            this.label12.TabIndex = 0;
            this.label12.Text = "Trạng Thái : ";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(38, 366);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 25);
            this.label11.TabIndex = 0;
            this.label11.Text = "Đơn Giá : ";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(38, 311);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(136, 25);
            this.label10.TabIndex = 0;
            this.label10.Text = "Tên Sản Phẩm : ";
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Location = new System.Drawing.Point(13, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 40);
            this.button1.TabIndex = 26;
            this.button1.Text = "   Thêm";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lbDonGia
            // 
            this.lbDonGia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbDonGia.AutoSize = true;
            this.lbDonGia.Location = new System.Drawing.Point(134, 366);
            this.lbDonGia.Name = "lbDonGia";
            this.lbDonGia.Size = new System.Drawing.Size(27, 25);
            this.lbDonGia.TabIndex = 0;
            this.lbDonGia.Text = "1 ";
            // 
            // lb_Tongtien
            // 
            this.lb_Tongtien.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_Tongtien.AutoSize = true;
            this.lb_Tongtien.Location = new System.Drawing.Point(158, 471);
            this.lb_Tongtien.Name = "lb_Tongtien";
            this.lb_Tongtien.Size = new System.Drawing.Size(27, 25);
            this.lb_Tongtien.TabIndex = 0;
            this.lb_Tongtien.Text = "1 ";
            // 
            // lbSoLuong
            // 
            this.lbSoLuong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbSoLuong.AutoSize = true;
            this.lbSoLuong.Location = new System.Drawing.Point(158, 423);
            this.lbSoLuong.Name = "lbSoLuong";
            this.lbSoLuong.Size = new System.Drawing.Size(27, 25);
            this.lbSoLuong.TabIndex = 0;
            this.lbSoLuong.Text = "1 ";
            // 
            // lbTenSanPham
            // 
            this.lbTenSanPham.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbTenSanPham.AutoSize = true;
            this.lbTenSanPham.Location = new System.Drawing.Point(191, 311);
            this.lbTenSanPham.Name = "lbTenSanPham";
            this.lbTenSanPham.Size = new System.Drawing.Size(27, 25);
            this.lbTenSanPham.TabIndex = 0;
            this.lbTenSanPham.Text = "1 ";
            // 
            // lbTrangThai
            // 
            this.lbTrangThai.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbTrangThai.AutoSize = true;
            this.lbTrangThai.Location = new System.Drawing.Point(150, 511);
            this.lbTrangThai.Name = "lbTrangThai";
            this.lbTrangThai.Size = new System.Drawing.Size(27, 25);
            this.lbTrangThai.TabIndex = 0;
            this.lbTrangThai.Text = "1 ";
            // 
            // lbMahoadon
            // 
            this.lbMahoadon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbMahoadon.AutoSize = true;
            this.lbMahoadon.Location = new System.Drawing.Point(183, 256);
            this.lbMahoadon.Name = "lbMahoadon";
            this.lbMahoadon.Size = new System.Drawing.Size(27, 25);
            this.lbMahoadon.TabIndex = 0;
            this.lbMahoadon.Text = "1 ";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(41, 256);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 25);
            this.label9.TabIndex = 0;
            this.label9.Text = "Mã Hóa Đơn : ";
            // 
            // grb_barcode
            // 
            this.grb_barcode.Controls.Add(this.pictureBox);
            this.grb_barcode.Controls.Add(this.Cammera);
            this.grb_barcode.Controls.Add(this.cboCamera);
            this.grb_barcode.Controls.Add(this.txtBarcode);
            this.grb_barcode.Controls.Add(this.btnStart);
            this.grb_barcode.Controls.Add(this.label2);
            this.grb_barcode.ForeColor = System.Drawing.Color.Black;
            this.grb_barcode.Location = new System.Drawing.Point(27, 352);
            this.grb_barcode.Name = "grb_barcode";
            this.grb_barcode.Size = new System.Drawing.Size(1021, 544);
            this.grb_barcode.TabIndex = 35;
            this.grb_barcode.TabStop = false;
            this.grb_barcode.Text = "BarCode";
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox.Location = new System.Drawing.Point(6, 65);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(1009, 358);
            this.pictureBox.TabIndex = 14;
            this.pictureBox.TabStop = false;
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
            // cboCamera
            // 
            this.cboCamera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCamera.FormattingEnabled = true;
            this.cboCamera.Location = new System.Drawing.Point(147, 26);
            this.cboCamera.Name = "cboCamera";
            this.cboCamera.Size = new System.Drawing.Size(868, 33);
            this.cboCamera.TabIndex = 13;
            // 
            // txtBarcode
            // 
            this.txtBarcode.Location = new System.Drawing.Point(147, 441);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(837, 31);
            this.txtBarcode.TabIndex = 15;
            this.txtBarcode.TextChanged += new System.EventHandler(this.txtBarcode_TextChanged);
            // 
            // btnStart
            // 
            this.btnStart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnStart.BackgroundImage")));
            this.btnStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnStart.Location = new System.Drawing.Point(854, 478);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(130, 40);
            this.btnStart.TabIndex = 16;
            this.btnStart.Text = "Bắt Đầu";
            this.btnStart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 444);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "Barcode :";
            // 
            // btn_ThanhToan
            // 
            this.btn_ThanhToan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ThanhToan.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_ThanhToan.BackgroundImage")));
            this.btn_ThanhToan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_ThanhToan.ForeColor = System.Drawing.Color.Navy;
            this.btn_ThanhToan.Location = new System.Drawing.Point(1637, 942);
            this.btn_ThanhToan.Name = "btn_ThanhToan";
            this.btn_ThanhToan.Size = new System.Drawing.Size(162, 57);
            this.btn_ThanhToan.TabIndex = 34;
            this.btn_ThanhToan.Text = "Thanh Toán";
            this.btn_ThanhToan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ThanhToan.UseVisualStyleBackColor = true;
            this.btn_ThanhToan.Click += new System.EventHandler(this.btn_ThanhToan_Click);
            // 
            // lbTongTien
            // 
            this.lbTongTien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTongTien.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTongTien.ForeColor = System.Drawing.Color.Red;
            this.lbTongTien.Location = new System.Drawing.Point(1399, 949);
            this.lbTongTien.Name = "lbTongTien";
            this.lbTongTien.Size = new System.Drawing.Size(185, 46);
            this.lbTongTien.TabIndex = 33;
            this.lbTongTien.Text = "Tổng Tiền ";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.Navy;
            this.label8.Location = new System.Drawing.Point(1240, 959);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 32);
            this.label8.TabIndex = 32;
            this.label8.Text = "Thành Tiền : ";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1861, 1012);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Hóa Đơn 2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Frm_BanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1869, 1050);
            this.Controls.Add(this.tabControl1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Frm_BanHang";
            this.Text = "Bán Hàng ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_BanHang_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_BanHang_FormClosed);
            this.Load += new System.EventHandler(this.Frm_BanHang_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.grb_SanPham.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgidSanPham)).EndInit();
            this.Hoa.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbr_SoLuong)).EndInit();
            this.grb_barcode.ResumeLayout(false);
            this.grb_barcode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btn_QuetMa;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown nbr_SoLuong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbDonGia;
        private System.Windows.Forms.Label lb_Tongtien;
        private System.Windows.Forms.Label lbSoLuong;
        private System.Windows.Forms.Label lbTenSanPham;
        private System.Windows.Forms.Label lbTrangThai;
        private System.Windows.Forms.Label lbMahoadon;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox grb_barcode;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label Cammera;
        private System.Windows.Forms.ComboBox cboCamera;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_ThanhToan;
        private System.Windows.Forms.Label lbTongTien;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox Hoa;
        private System.Windows.Forms.GroupBox grb_SanPham;
        private System.Windows.Forms.DataGridView dgidSanPham;
        private System.Windows.Forms.ListView lv_HoaDon;
    }
}