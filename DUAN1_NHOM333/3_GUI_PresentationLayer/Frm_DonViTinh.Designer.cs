
namespace _3_GUI_PresentationLayer
{
    partial class Frm_DonViTinh
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
            this.tbx_Madonvitinh = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbx_TenDVT = new System.Windows.Forms.TextBox();
            this.rbt_HoatDong = new System.Windows.Forms.RadioButton();
            this.rbt_KhongHoatDong = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.dtgrid_DonViTinh = new System.Windows.Forms.DataGridView();
            this.btn_ThemDVT = new System.Windows.Forms.Button();
            this.btn_XoaDVT = new System.Windows.Forms.Button();
            this.btn_SuaDVT = new System.Windows.Forms.Button();
            this.cbx_ChatLieu = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid_DonViTinh)).BeginInit();
            this.SuspendLayout();
            // 
            // tbx_Madonvitinh
            // 
            this.tbx_Madonvitinh.Location = new System.Drawing.Point(132, 31);
            this.tbx_Madonvitinh.Name = "tbx_Madonvitinh";
            this.tbx_Madonvitinh.Size = new System.Drawing.Size(254, 27);
            this.tbx_Madonvitinh.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Đơn Vị Tính:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên Đơn Vị Tính:";
            // 
            // tbx_TenDVT
            // 
            this.tbx_TenDVT.Location = new System.Drawing.Point(134, 83);
            this.tbx_TenDVT.Name = "tbx_TenDVT";
            this.tbx_TenDVT.Size = new System.Drawing.Size(252, 27);
            this.tbx_TenDVT.TabIndex = 3;
            // 
            // rbt_HoatDong
            // 
            this.rbt_HoatDong.AutoSize = true;
            this.rbt_HoatDong.Location = new System.Drawing.Point(132, 138);
            this.rbt_HoatDong.Name = "rbt_HoatDong";
            this.rbt_HoatDong.Size = new System.Drawing.Size(102, 24);
            this.rbt_HoatDong.TabIndex = 4;
            this.rbt_HoatDong.TabStop = true;
            this.rbt_HoatDong.Text = "Hoạt động";
            this.rbt_HoatDong.UseVisualStyleBackColor = true;
            // 
            // rbt_KhongHoatDong
            // 
            this.rbt_KhongHoatDong.AutoSize = true;
            this.rbt_KhongHoatDong.Location = new System.Drawing.Point(240, 138);
            this.rbt_KhongHoatDong.Name = "rbt_KhongHoatDong";
            this.rbt_KhongHoatDong.Size = new System.Drawing.Size(146, 24);
            this.rbt_KhongHoatDong.TabIndex = 5;
            this.rbt_KhongHoatDong.TabStop = true;
            this.rbt_KhongHoatDong.Text = "Không hoạt động";
            this.rbt_KhongHoatDong.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Trạng thái:";
            // 
            // dtgrid_DonViTinh
            // 
            this.dtgrid_DonViTinh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgrid_DonViTinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrid_DonViTinh.Location = new System.Drawing.Point(12, 230);
            this.dtgrid_DonViTinh.Name = "dtgrid_DonViTinh";
            this.dtgrid_DonViTinh.RowHeadersWidth = 51;
            this.dtgrid_DonViTinh.RowTemplate.Height = 29;
            this.dtgrid_DonViTinh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgrid_DonViTinh.Size = new System.Drawing.Size(608, 188);
            this.dtgrid_DonViTinh.TabIndex = 7;
            this.dtgrid_DonViTinh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrid_DonViTinh_CellClick);
            // 
            // btn_ThemDVT
            // 
            this.btn_ThemDVT.Location = new System.Drawing.Point(476, 25);
            this.btn_ThemDVT.Name = "btn_ThemDVT";
            this.btn_ThemDVT.Size = new System.Drawing.Size(94, 29);
            this.btn_ThemDVT.TabIndex = 8;
            this.btn_ThemDVT.Text = "Thêm";
            this.btn_ThemDVT.UseVisualStyleBackColor = true;
            this.btn_ThemDVT.Click += new System.EventHandler(this.btn_ThemDVT_Click);
            // 
            // btn_XoaDVT
            // 
            this.btn_XoaDVT.Location = new System.Drawing.Point(476, 95);
            this.btn_XoaDVT.Name = "btn_XoaDVT";
            this.btn_XoaDVT.Size = new System.Drawing.Size(94, 29);
            this.btn_XoaDVT.TabIndex = 9;
            this.btn_XoaDVT.Text = "Xóa";
            this.btn_XoaDVT.UseVisualStyleBackColor = true;
            this.btn_XoaDVT.Click += new System.EventHandler(this.btn_XoaDVT_Click);
            // 
            // btn_SuaDVT
            // 
            this.btn_SuaDVT.Location = new System.Drawing.Point(476, 60);
            this.btn_SuaDVT.Name = "btn_SuaDVT";
            this.btn_SuaDVT.Size = new System.Drawing.Size(94, 29);
            this.btn_SuaDVT.TabIndex = 10;
            this.btn_SuaDVT.Text = "Sửa";
            this.btn_SuaDVT.UseVisualStyleBackColor = true;
            this.btn_SuaDVT.Click += new System.EventHandler(this.btn_SuaDVT_Click);
            // 
            // cbx_ChatLieu
            // 
            this.cbx_ChatLieu.FormattingEnabled = true;
            this.cbx_ChatLieu.Location = new System.Drawing.Point(132, 184);
            this.cbx_ChatLieu.Name = "cbx_ChatLieu";
            this.cbx_ChatLieu.Size = new System.Drawing.Size(151, 28);
            this.cbx_ChatLieu.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Chất liệu:";
            // 
            // Frm_DonViTinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 430);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbx_ChatLieu);
            this.Controls.Add(this.btn_SuaDVT);
            this.Controls.Add(this.btn_XoaDVT);
            this.Controls.Add(this.btn_ThemDVT);
            this.Controls.Add(this.dtgrid_DonViTinh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rbt_KhongHoatDong);
            this.Controls.Add(this.rbt_HoatDong);
            this.Controls.Add(this.tbx_TenDVT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbx_Madonvitinh);
            this.Name = "Frm_DonViTinh";
            this.Text = "DonViTinh";
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid_DonViTinh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbx_Madonvitinh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbx_TenDVT;
        private System.Windows.Forms.RadioButton rbt_HoatDong;
        private System.Windows.Forms.RadioButton rbt_KhongHoatDong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dtgrid_DonViTinh;
        private System.Windows.Forms.Button btn_ThemDVT;
        private System.Windows.Forms.Button btn_XoaDVT;
        private System.Windows.Forms.Button btn_SuaDVT;
        private System.Windows.Forms.ComboBox cbx_ChatLieu;
        private System.Windows.Forms.Label label4;
    }
}