
namespace _3_GUI_PresentationLayer
{
    partial class Frm_ThongTinSanPham
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
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.cboCamera = new System.Windows.Forms.ComboBox();
            this.Cammera = new System.Windows.Forms.Label();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.txtSoluong = new System.Windows.Forms.TextBox();
            this.txtTrongLuong = new System.Windows.Forms.TextBox();
            this.cbxXuatXu = new System.Windows.Forms.ComboBox();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbxDonViTinh = new System.Windows.Forms.ComboBox();
            this.cbxLoaiHang = new System.Windows.Forms.ComboBox();
            this.dgid_Data = new System.Windows.Forms.DataGridView();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMaSanPham = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgid_Data)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 377);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Barcode :";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(318, 408);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(174, 50);
            this.btnStart.TabIndex = 10;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtBarcode
            // 
            this.txtBarcode.Location = new System.Drawing.Point(138, 371);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(354, 31);
            this.txtBarcode.TabIndex = 9;
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox.Location = new System.Drawing.Point(52, 93);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(440, 271);
            this.pictureBox.TabIndex = 8;
            this.pictureBox.TabStop = false;
            // 
            // cboCamera
            // 
            this.cboCamera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCamera.FormattingEnabled = true;
            this.cboCamera.Location = new System.Drawing.Point(138, 32);
            this.cboCamera.Name = "cboCamera";
            this.cboCamera.Size = new System.Drawing.Size(354, 33);
            this.cboCamera.TabIndex = 7;
            // 
            // Cammera
            // 
            this.Cammera.AutoSize = true;
            this.Cammera.Location = new System.Drawing.Point(30, 35);
            this.Cammera.Name = "Cammera";
            this.Cammera.Size = new System.Drawing.Size(102, 25);
            this.Cammera.TabIndex = 6;
            this.Cammera.Text = "Cammera : ";
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtGiaBan.Location = new System.Drawing.Point(645, 93);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(317, 39);
            this.txtGiaBan.TabIndex = 12;
            // 
            // txtSoluong
            // 
            this.txtSoluong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSoluong.Location = new System.Drawing.Point(645, 147);
            this.txtSoluong.Name = "txtSoluong";
            this.txtSoluong.Size = new System.Drawing.Size(317, 39);
            this.txtSoluong.TabIndex = 12;
            // 
            // txtTrongLuong
            // 
            this.txtTrongLuong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTrongLuong.Location = new System.Drawing.Point(645, 192);
            this.txtTrongLuong.Name = "txtTrongLuong";
            this.txtTrongLuong.Size = new System.Drawing.Size(317, 39);
            this.txtTrongLuong.TabIndex = 12;
            // 
            // cbxXuatXu
            // 
            this.cbxXuatXu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbxXuatXu.FormattingEnabled = true;
            this.cbxXuatXu.Location = new System.Drawing.Point(645, 370);
            this.cbxXuatXu.Name = "cbxXuatXu";
            this.cbxXuatXu.Size = new System.Drawing.Size(317, 40);
            this.cbxXuatXu.TabIndex = 13;
            // 
            // txtMoTa
            // 
            this.txtMoTa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMoTa.Location = new System.Drawing.Point(645, 416);
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(317, 39);
            this.txtMoTa.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(540, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Giá Bán : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(527, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Số Lượng : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(503, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "Trong Lượng : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(512, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "Đơn Vị Tính : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(515, 320);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "Loại Hàng : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(527, 383);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "Xuất Xứ : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(540, 430);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 25);
            this.label8.TabIndex = 14;
            this.label8.Text = "Mô Tả : ";
            // 
            // cbxDonViTinh
            // 
            this.cbxDonViTinh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbxDonViTinh.FormattingEnabled = true;
            this.cbxDonViTinh.Location = new System.Drawing.Point(645, 255);
            this.cbxDonViTinh.Name = "cbxDonViTinh";
            this.cbxDonViTinh.Size = new System.Drawing.Size(317, 40);
            this.cbxDonViTinh.TabIndex = 15;
            // 
            // cbxLoaiHang
            // 
            this.cbxLoaiHang.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbxLoaiHang.FormattingEnabled = true;
            this.cbxLoaiHang.Location = new System.Drawing.Point(645, 311);
            this.cbxLoaiHang.Name = "cbxLoaiHang";
            this.cbxLoaiHang.Size = new System.Drawing.Size(317, 40);
            this.cbxLoaiHang.TabIndex = 15;
            // 
            // dgid_Data
            // 
            this.dgid_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgid_Data.Location = new System.Drawing.Point(47, 494);
            this.dgid_Data.Name = "dgid_Data";
            this.dgid_Data.RowHeadersWidth = 62;
            this.dgid_Data.RowTemplate.Height = 33;
            this.dgid_Data.Size = new System.Drawing.Size(1077, 225);
            this.dgid_Data.TabIndex = 16;
            this.dgid_Data.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgid_Data_CellClick);
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(999, 67);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(148, 47);
            this.btn_Them.TabIndex = 17;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(999, 134);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(148, 47);
            this.btnSua.TabIndex = 17;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(503, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 25);
            this.label9.TabIndex = 14;
            this.label9.Text = "Mã Sản Phẩm : ";
            // 
            // txtMaSanPham
            // 
            this.txtMaSanPham.Enabled = false;
            this.txtMaSanPham.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMaSanPham.Location = new System.Drawing.Point(645, 26);
            this.txtMaSanPham.Name = "txtMaSanPham";
            this.txtMaSanPham.Size = new System.Drawing.Size(317, 39);
            this.txtMaSanPham.TabIndex = 12;
            // 
            // Frm_ThongTinSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 731);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.dgid_Data);
            this.Controls.Add(this.cbxLoaiHang);
            this.Controls.Add(this.cbxDonViTinh);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxXuatXu);
            this.Controls.Add(this.txtMoTa);
            this.Controls.Add(this.txtTrongLuong);
            this.Controls.Add(this.txtSoluong);
            this.Controls.Add(this.txtMaSanPham);
            this.Controls.Add(this.txtGiaBan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtBarcode);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.cboCamera);
            this.Controls.Add(this.Cammera);
            this.Name = "Frm_ThongTinSanPham";
            this.Text = "Frm_ThongTinSanPham";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_ThongTinSanPham_FormClosing);
            this.Load += new System.EventHandler(this.Frm_ThongTinSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgid_Data)).EndInit();
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
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.TextBox txtSoluong;
        private System.Windows.Forms.TextBox txtTrongLuong;
        private System.Windows.Forms.ComboBox cbxXuatXu;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbxDonViTinh;
        private System.Windows.Forms.ComboBox cbxLoaiHang;
        private System.Windows.Forms.DataGridView dgid_Data;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMaSanPham;
    }
}