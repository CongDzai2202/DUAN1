
namespace _3_GUI_PresentationLayer
{
    partial class Frm_XuatXu
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
            this.tbx_MaXuatXu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbx_TenNuoc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rbt_KhongHĐ = new System.Windows.Forms.RadioButton();
            this.rbt_HoatDong = new System.Windows.Forms.RadioButton();
            this.dtgrid_XuatXu = new System.Windows.Forms.DataGridView();
            this.btn_ThemXuatXu = new System.Windows.Forms.Button();
            this.btn_XoaXX = new System.Windows.Forms.Button();
            this.btn_SuaXX = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid_XuatXu)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã xuất xứ:";
            // 
            // tbx_MaXuatXu
            // 
            this.tbx_MaXuatXu.Location = new System.Drawing.Point(131, 60);
            this.tbx_MaXuatXu.Name = "tbx_MaXuatXu";
            this.tbx_MaXuatXu.Size = new System.Drawing.Size(174, 27);
            this.tbx_MaXuatXu.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên nước:";
            // 
            // tbx_TenNuoc
            // 
            this.tbx_TenNuoc.Location = new System.Drawing.Point(131, 104);
            this.tbx_TenNuoc.Name = "tbx_TenNuoc";
            this.tbx_TenNuoc.Size = new System.Drawing.Size(174, 27);
            this.tbx_TenNuoc.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Trạng thái:";
            // 
            // rbt_KhongHĐ
            // 
            this.rbt_KhongHĐ.AutoSize = true;
            this.rbt_KhongHĐ.Location = new System.Drawing.Point(238, 150);
            this.rbt_KhongHĐ.Name = "rbt_KhongHĐ";
            this.rbt_KhongHĐ.Size = new System.Drawing.Size(146, 24);
            this.rbt_KhongHĐ.TabIndex = 12;
            this.rbt_KhongHĐ.TabStop = true;
            this.rbt_KhongHĐ.Text = "Không hoạt động";
            this.rbt_KhongHĐ.UseVisualStyleBackColor = true;
            // 
            // rbt_HoatDong
            // 
            this.rbt_HoatDong.AutoSize = true;
            this.rbt_HoatDong.Location = new System.Drawing.Point(130, 150);
            this.rbt_HoatDong.Name = "rbt_HoatDong";
            this.rbt_HoatDong.Size = new System.Drawing.Size(102, 24);
            this.rbt_HoatDong.TabIndex = 11;
            this.rbt_HoatDong.TabStop = true;
            this.rbt_HoatDong.Text = "Hoạt động";
            this.rbt_HoatDong.UseVisualStyleBackColor = true;
            // 
            // dtgrid_XuatXu
            // 
            this.dtgrid_XuatXu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgrid_XuatXu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrid_XuatXu.Location = new System.Drawing.Point(3, 195);
            this.dtgrid_XuatXu.Name = "dtgrid_XuatXu";
            this.dtgrid_XuatXu.RowHeadersWidth = 51;
            this.dtgrid_XuatXu.RowTemplate.Height = 29;
            this.dtgrid_XuatXu.Size = new System.Drawing.Size(528, 240);
            this.dtgrid_XuatXu.TabIndex = 14;
            this.dtgrid_XuatXu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrid_XuatXu_CellClick);
            // 
            // btn_ThemXuatXu
            // 
            this.btn_ThemXuatXu.Location = new System.Drawing.Point(400, 51);
            this.btn_ThemXuatXu.Name = "btn_ThemXuatXu";
            this.btn_ThemXuatXu.Size = new System.Drawing.Size(94, 29);
            this.btn_ThemXuatXu.TabIndex = 15;
            this.btn_ThemXuatXu.Text = "Thêm";
            this.btn_ThemXuatXu.UseVisualStyleBackColor = true;
            this.btn_ThemXuatXu.Click += new System.EventHandler(this.btn_ThemXuatXu_Click);
            // 
            // btn_XoaXX
            // 
            this.btn_XoaXX.Location = new System.Drawing.Point(400, 121);
            this.btn_XoaXX.Name = "btn_XoaXX";
            this.btn_XoaXX.Size = new System.Drawing.Size(94, 29);
            this.btn_XoaXX.TabIndex = 16;
            this.btn_XoaXX.Text = "Xóa";
            this.btn_XoaXX.UseVisualStyleBackColor = true;
            this.btn_XoaXX.Click += new System.EventHandler(this.btn_XoaXX_Click);
            // 
            // btn_SuaXX
            // 
            this.btn_SuaXX.Location = new System.Drawing.Point(400, 86);
            this.btn_SuaXX.Name = "btn_SuaXX";
            this.btn_SuaXX.Size = new System.Drawing.Size(94, 29);
            this.btn_SuaXX.TabIndex = 17;
            this.btn_SuaXX.Text = "Sửa";
            this.btn_SuaXX.UseVisualStyleBackColor = true;
            this.btn_SuaXX.Click += new System.EventHandler(this.btn_SuaXX_Click);
            // 
            // Frm_XuatXu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 434);
            this.Controls.Add(this.btn_SuaXX);
            this.Controls.Add(this.btn_XoaXX);
            this.Controls.Add(this.btn_ThemXuatXu);
            this.Controls.Add(this.dtgrid_XuatXu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rbt_KhongHĐ);
            this.Controls.Add(this.rbt_HoatDong);
            this.Controls.Add(this.tbx_TenNuoc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbx_MaXuatXu);
            this.Controls.Add(this.label1);
            this.Name = "Frm_XuatXu";
            this.Text = "Frm_XuatXu";
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid_XuatXu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbx_MaXuatXu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbx_TenNuoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbt_KhongHĐ;
        private System.Windows.Forms.RadioButton rbt_HoatDong;
        private System.Windows.Forms.DataGridView dtgrid_XuatXu;
        private System.Windows.Forms.Button btn_ThemXuatXu;
        private System.Windows.Forms.Button btn_XoaXX;
        private System.Windows.Forms.Button btn_SuaXX;
    }
}