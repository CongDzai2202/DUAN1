
namespace _3_GUI_PresentationLayer
{
    partial class Frm_NhanVien
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
            this.label1 = new System.Windows.Forms.Label();
            this.txb_SDTNV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_MatKhau = new System.Windows.Forms.TextBox();
            this.dtgrid_NhanVien = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.rbt_HoatDong = new System.Windows.Forms.RadioButton();
            this.rbt_KhongHĐ = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txb_TenNhanVien = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txb_CMND = new System.Windows.Forms.TextBox();
            this.txb_DiaChi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbx_ChucVu = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbx_NamSinh = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.tbx_TimKiem = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid_NhanVien)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số điện thoại:";
            // 
            // txb_SDTNV
            // 
            this.txb_SDTNV.Location = new System.Drawing.Point(137, 123);
            this.txb_SDTNV.Name = "txb_SDTNV";
            this.txb_SDTNV.Size = new System.Drawing.Size(271, 27);
            this.txb_SDTNV.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mật khẩu:";
            // 
            // txb_MatKhau
            // 
            this.txb_MatKhau.Location = new System.Drawing.Point(137, 156);
            this.txb_MatKhau.Name = "txb_MatKhau";
            this.txb_MatKhau.Size = new System.Drawing.Size(271, 27);
            this.txb_MatKhau.TabIndex = 3;
            // 
            // dtgrid_NhanVien
            // 
            this.dtgrid_NhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgrid_NhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrid_NhanVien.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgrid_NhanVien.Location = new System.Drawing.Point(12, 278);
            this.dtgrid_NhanVien.Name = "dtgrid_NhanVien";
            this.dtgrid_NhanVien.RowHeadersWidth = 51;
            this.dtgrid_NhanVien.RowTemplate.Height = 29;
            this.dtgrid_NhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgrid_NhanVien.Size = new System.Drawing.Size(958, 271);
            this.dtgrid_NhanVien.TabIndex = 4;
            this.dtgrid_NhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrid_NhanVien_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tình trạng:";
            // 
            // rbt_HoatDong
            // 
            this.rbt_HoatDong.AutoSize = true;
            this.rbt_HoatDong.Location = new System.Drawing.Point(137, 194);
            this.rbt_HoatDong.Name = "rbt_HoatDong";
            this.rbt_HoatDong.Size = new System.Drawing.Size(104, 24);
            this.rbt_HoatDong.TabIndex = 6;
            this.rbt_HoatDong.TabStop = true;
            this.rbt_HoatDong.Text = "Hoạt Động";
            this.rbt_HoatDong.UseVisualStyleBackColor = true;
            // 
            // rbt_KhongHĐ
            // 
            this.rbt_KhongHĐ.AutoSize = true;
            this.rbt_KhongHĐ.Location = new System.Drawing.Point(257, 194);
            this.rbt_KhongHĐ.Name = "rbt_KhongHĐ";
            this.rbt_KhongHĐ.Size = new System.Drawing.Size(151, 24);
            this.rbt_KhongHĐ.TabIndex = 7;
            this.rbt_KhongHĐ.TabStop = true;
            this.rbt_KhongHĐ.Text = "Không Hoạt Động";
            this.rbt_KhongHĐ.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tên nhân viên:";
            // 
            // txb_TenNhanVien
            // 
            this.txb_TenNhanVien.Location = new System.Drawing.Point(137, 20);
            this.txb_TenNhanVien.Name = "txb_TenNhanVien";
            this.txb_TenNhanVien.Size = new System.Drawing.Size(271, 27);
            this.txb_TenNhanVien.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Số CMND:";
            // 
            // txb_CMND
            // 
            this.txb_CMND.Location = new System.Drawing.Point(137, 56);
            this.txb_CMND.Name = "txb_CMND";
            this.txb_CMND.Size = new System.Drawing.Size(271, 27);
            this.txb_CMND.TabIndex = 11;
            // 
            // txb_DiaChi
            // 
            this.txb_DiaChi.Location = new System.Drawing.Point(699, 20);
            this.txb_DiaChi.Multiline = true;
            this.txb_DiaChi.Name = "txb_DiaChi";
            this.txb_DiaChi.Size = new System.Drawing.Size(271, 59);
            this.txb_DiaChi.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(622, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Địa chỉ:";
            // 
            // cbx_ChucVu
            // 
            this.cbx_ChucVu.FormattingEnabled = true;
            this.cbx_ChucVu.Location = new System.Drawing.Point(699, 100);
            this.cbx_ChucVu.Name = "cbx_ChucVu";
            this.cbx_ChucVu.Size = new System.Drawing.Size(271, 28);
            this.cbx_ChucVu.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(616, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Chức vụ:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(38, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Năm Sinh:";
            // 
            // cbx_NamSinh
            // 
            this.cbx_NamSinh.FormattingEnabled = true;
            this.cbx_NamSinh.Location = new System.Drawing.Point(137, 90);
            this.cbx_NamSinh.Name = "cbx_NamSinh";
            this.cbx_NamSinh.Size = new System.Drawing.Size(271, 28);
            this.cbx_NamSinh.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btn_Xoa);
            this.groupBox1.Controls.Add(this.btn_Sua);
            this.groupBox1.Controls.Add(this.btn_Them);
            this.groupBox1.Location = new System.Drawing.Point(443, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(155, 171);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(26, 131);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 3;
            this.button1.Text = "Trở về";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_Xoa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Xoa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Xoa.Location = new System.Drawing.Point(26, 96);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(94, 29);
            this.btn_Xoa.TabIndex = 2;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_Sua.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Sua.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Sua.Location = new System.Drawing.Point(26, 61);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(94, 29);
            this.btn_Sua.TabIndex = 1;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = false;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_Them.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Them.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Them.Location = new System.Drawing.Point(26, 26);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(94, 29);
            this.btn_Them.TabIndex = 0;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // tbx_TimKiem
            // 
            this.tbx_TimKiem.Location = new System.Drawing.Point(699, 245);
            this.tbx_TimKiem.Name = "tbx_TimKiem";
            this.tbx_TimKiem.PlaceholderText = "Nhập số điện thoại hoặc tên nhân viên";
            this.tbx_TimKiem.Size = new System.Drawing.Size(269, 27);
            this.tbx_TimKiem.TabIndex = 19;
            this.tbx_TimKiem.TextChanged += new System.EventHandler(this.tbx_TimKiem_TextChanged);
            // 
            // Frm_NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 563);
            this.Controls.Add(this.tbx_TimKiem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbx_NamSinh);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbx_ChucVu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txb_DiaChi);
            this.Controls.Add(this.txb_CMND);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txb_TenNhanVien);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rbt_KhongHĐ);
            this.Controls.Add(this.rbt_HoatDong);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtgrid_NhanVien);
            this.Controls.Add(this.txb_MatKhau);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txb_SDTNV);
            this.Controls.Add(this.label1);
            this.Name = "Frm_NhanVien";
            this.Text = "Frm_NhanVien";
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid_NhanVien)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb_SDTNV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb_MatKhau;
        private System.Windows.Forms.DataGridView dtgrid_NhanVien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbt_HoatDong;
        private System.Windows.Forms.RadioButton rbt_KhongHĐ;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txb_TenNhanVien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txb_CMND;
        private System.Windows.Forms.TextBox txb_DiaChi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbx_ChucVu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbx_NamSinh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.TextBox tbx_TimKiem;
        private System.Windows.Forms.Button button1;
    }
}