
namespace _3_GUI_PresentationLayer
{
    partial class Frm_LoaiHang
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
            this.tbx_MaLoaiHang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbx_TenLoaiHang = new System.Windows.Forms.TextBox();
            this.btn_ThemLh = new System.Windows.Forms.Button();
            this.btn_SuaLH = new System.Windows.Forms.Button();
            this.btn_XoaLh = new System.Windows.Forms.Button();
            this.dtgrid_LoaiHang = new System.Windows.Forms.DataGridView();
            this.rbt_HoatDong = new System.Windows.Forms.RadioButton();
            this.rbt_KhongHĐ = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid_LoaiHang)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã loại hàng:";
            // 
            // tbx_MaLoaiHang
            // 
            this.tbx_MaLoaiHang.Location = new System.Drawing.Point(118, 51);
            this.tbx_MaLoaiHang.Name = "tbx_MaLoaiHang";
            this.tbx_MaLoaiHang.Size = new System.Drawing.Size(191, 27);
            this.tbx_MaLoaiHang.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên loại hàng:";
            // 
            // tbx_TenLoaiHang
            // 
            this.tbx_TenLoaiHang.Location = new System.Drawing.Point(118, 107);
            this.tbx_TenLoaiHang.Name = "tbx_TenLoaiHang";
            this.tbx_TenLoaiHang.Size = new System.Drawing.Size(191, 27);
            this.tbx_TenLoaiHang.TabIndex = 3;
            // 
            // btn_ThemLh
            // 
            this.btn_ThemLh.Location = new System.Drawing.Point(406, 42);
            this.btn_ThemLh.Name = "btn_ThemLh";
            this.btn_ThemLh.Size = new System.Drawing.Size(94, 29);
            this.btn_ThemLh.TabIndex = 4;
            this.btn_ThemLh.Text = "Thêm";
            this.btn_ThemLh.UseVisualStyleBackColor = true;
            this.btn_ThemLh.Click += new System.EventHandler(this.btn_ThemLh_Click);
            // 
            // btn_SuaLH
            // 
            this.btn_SuaLH.Location = new System.Drawing.Point(406, 77);
            this.btn_SuaLH.Name = "btn_SuaLH";
            this.btn_SuaLH.Size = new System.Drawing.Size(94, 29);
            this.btn_SuaLH.TabIndex = 5;
            this.btn_SuaLH.Text = "Sửa";
            this.btn_SuaLH.UseVisualStyleBackColor = true;
            this.btn_SuaLH.Click += new System.EventHandler(this.btn_SuaLH_Click);
            // 
            // btn_XoaLh
            // 
            this.btn_XoaLh.Location = new System.Drawing.Point(406, 112);
            this.btn_XoaLh.Name = "btn_XoaLh";
            this.btn_XoaLh.Size = new System.Drawing.Size(94, 29);
            this.btn_XoaLh.TabIndex = 6;
            this.btn_XoaLh.Text = "Xóa";
            this.btn_XoaLh.UseVisualStyleBackColor = true;
            this.btn_XoaLh.Click += new System.EventHandler(this.btn_XoaLh_Click);
            // 
            // dtgrid_LoaiHang
            // 
            this.dtgrid_LoaiHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgrid_LoaiHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrid_LoaiHang.Location = new System.Drawing.Point(3, 231);
            this.dtgrid_LoaiHang.Name = "dtgrid_LoaiHang";
            this.dtgrid_LoaiHang.RowHeadersWidth = 51;
            this.dtgrid_LoaiHang.RowTemplate.Height = 29;
            this.dtgrid_LoaiHang.Size = new System.Drawing.Size(551, 169);
            this.dtgrid_LoaiHang.TabIndex = 7;
            this.dtgrid_LoaiHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrid_LoaiHang_CellClick);
            // 
            // rbt_HoatDong
            // 
            this.rbt_HoatDong.AutoSize = true;
            this.rbt_HoatDong.Location = new System.Drawing.Point(118, 164);
            this.rbt_HoatDong.Name = "rbt_HoatDong";
            this.rbt_HoatDong.Size = new System.Drawing.Size(102, 24);
            this.rbt_HoatDong.TabIndex = 8;
            this.rbt_HoatDong.TabStop = true;
            this.rbt_HoatDong.Text = "Hoạt động";
            this.rbt_HoatDong.UseVisualStyleBackColor = true;
            // 
            // rbt_KhongHĐ
            // 
            this.rbt_KhongHĐ.AutoSize = true;
            this.rbt_KhongHĐ.Location = new System.Drawing.Point(226, 164);
            this.rbt_KhongHĐ.Name = "rbt_KhongHĐ";
            this.rbt_KhongHĐ.Size = new System.Drawing.Size(146, 24);
            this.rbt_KhongHĐ.TabIndex = 9;
            this.rbt_KhongHĐ.TabStop = true;
            this.rbt_KhongHĐ.Text = "Không hoạt động";
            this.rbt_KhongHĐ.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Trạng thái:";
            // 
            // Frm_LoaiHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 412);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rbt_KhongHĐ);
            this.Controls.Add(this.rbt_HoatDong);
            this.Controls.Add(this.dtgrid_LoaiHang);
            this.Controls.Add(this.btn_XoaLh);
            this.Controls.Add(this.btn_SuaLH);
            this.Controls.Add(this.btn_ThemLh);
            this.Controls.Add(this.tbx_TenLoaiHang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbx_MaLoaiHang);
            this.Controls.Add(this.label1);
            this.Name = "Frm_LoaiHang";
            this.Text = "Frm_LoaiHang";
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid_LoaiHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbx_MaLoaiHang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbx_TenLoaiHang;
        private System.Windows.Forms.Button btn_ThemLh;
        private System.Windows.Forms.Button btn_SuaLH;
        private System.Windows.Forms.Button btn_XoaLh;
        private System.Windows.Forms.DataGridView dtgrid_LoaiHang;
        private System.Windows.Forms.RadioButton rbt_HoatDong;
        private System.Windows.Forms.RadioButton rbt_KhongHĐ;
        private System.Windows.Forms.Label label3;
    }
}