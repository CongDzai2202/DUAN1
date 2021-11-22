
namespace _3_GUI_PresentationLayer
{
    partial class Frm_GiaoDien
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_GiaoDien));
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.btn_QuanLy = new FontAwesome.Sharp.IconButton();
            this.btn_NhapHang = new FontAwesome.Sharp.IconButton();
            this.btn_SanPham = new FontAwesome.Sharp.IconButton();
            this.btn_NhanVien = new FontAwesome.Sharp.IconButton();
            this.btn_BanHang = new FontAwesome.Sharp.IconButton();
            this.btn_GiaoDienChinh = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Home = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PanelMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Home)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.Color.Teal;
            this.PanelMenu.Controls.Add(this.btn_QuanLy);
            this.PanelMenu.Controls.Add(this.btn_NhapHang);
            this.PanelMenu.Controls.Add(this.btn_SanPham);
            this.PanelMenu.Controls.Add(this.btn_NhanVien);
            this.PanelMenu.Controls.Add(this.btn_BanHang);
            this.PanelMenu.Controls.Add(this.btn_GiaoDienChinh);
            this.PanelMenu.Controls.Add(this.panel2);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenu.Location = new System.Drawing.Point(0, 0);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(220, 655);
            this.PanelMenu.TabIndex = 0;
            this.PanelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btn_QuanLy
            // 
            this.btn_QuanLy.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_QuanLy.FlatAppearance.BorderSize = 0;
            this.btn_QuanLy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_QuanLy.ForeColor = System.Drawing.Color.Navy;
            this.btn_QuanLy.IconChar = FontAwesome.Sharp.IconChar.UserCog;
            this.btn_QuanLy.IconColor = System.Drawing.Color.Navy;
            this.btn_QuanLy.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_QuanLy.IconSize = 32;
            this.btn_QuanLy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_QuanLy.Location = new System.Drawing.Point(0, 450);
            this.btn_QuanLy.Name = "btn_QuanLy";
            this.btn_QuanLy.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btn_QuanLy.Size = new System.Drawing.Size(220, 60);
            this.btn_QuanLy.TabIndex = 6;
            this.btn_QuanLy.Text = "Quản Lý";
            this.btn_QuanLy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_QuanLy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_QuanLy.UseVisualStyleBackColor = true;
            this.btn_QuanLy.Click += new System.EventHandler(this.btn_QuanLy_Click);
            // 
            // btn_NhapHang
            // 
            this.btn_NhapHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_NhapHang.FlatAppearance.BorderSize = 0;
            this.btn_NhapHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_NhapHang.ForeColor = System.Drawing.Color.Navy;
            this.btn_NhapHang.IconChar = FontAwesome.Sharp.IconChar.Truck;
            this.btn_NhapHang.IconColor = System.Drawing.Color.Navy;
            this.btn_NhapHang.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_NhapHang.IconSize = 32;
            this.btn_NhapHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_NhapHang.Location = new System.Drawing.Point(0, 390);
            this.btn_NhapHang.Name = "btn_NhapHang";
            this.btn_NhapHang.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btn_NhapHang.Size = new System.Drawing.Size(220, 60);
            this.btn_NhapHang.TabIndex = 5;
            this.btn_NhapHang.Text = "Nhập Hàng";
            this.btn_NhapHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_NhapHang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_NhapHang.UseVisualStyleBackColor = true;
            this.btn_NhapHang.Click += new System.EventHandler(this.btn_NhapHang_Click);
            // 
            // btn_SanPham
            // 
            this.btn_SanPham.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_SanPham.FlatAppearance.BorderSize = 0;
            this.btn_SanPham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SanPham.ForeColor = System.Drawing.Color.Navy;
            this.btn_SanPham.IconChar = FontAwesome.Sharp.IconChar.PizzaSlice;
            this.btn_SanPham.IconColor = System.Drawing.Color.Navy;
            this.btn_SanPham.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_SanPham.IconSize = 32;
            this.btn_SanPham.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SanPham.Location = new System.Drawing.Point(0, 330);
            this.btn_SanPham.Name = "btn_SanPham";
            this.btn_SanPham.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btn_SanPham.Size = new System.Drawing.Size(220, 60);
            this.btn_SanPham.TabIndex = 4;
            this.btn_SanPham.Text = "Sản Phẩm";
            this.btn_SanPham.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SanPham.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_SanPham.UseVisualStyleBackColor = true;
            this.btn_SanPham.Click += new System.EventHandler(this.btn_SanPham_Click);
            // 
            // btn_NhanVien
            // 
            this.btn_NhanVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_NhanVien.FlatAppearance.BorderSize = 0;
            this.btn_NhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_NhanVien.ForeColor = System.Drawing.Color.Navy;
            this.btn_NhanVien.IconChar = FontAwesome.Sharp.IconChar.Portrait;
            this.btn_NhanVien.IconColor = System.Drawing.Color.Navy;
            this.btn_NhanVien.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_NhanVien.IconSize = 32;
            this.btn_NhanVien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_NhanVien.Location = new System.Drawing.Point(0, 270);
            this.btn_NhanVien.Name = "btn_NhanVien";
            this.btn_NhanVien.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btn_NhanVien.Size = new System.Drawing.Size(220, 60);
            this.btn_NhanVien.TabIndex = 3;
            this.btn_NhanVien.Text = "Nhân Viên";
            this.btn_NhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_NhanVien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_NhanVien.UseVisualStyleBackColor = true;
            this.btn_NhanVien.Click += new System.EventHandler(this.btn_NhanVien_Click);
            // 
            // btn_BanHang
            // 
            this.btn_BanHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_BanHang.FlatAppearance.BorderSize = 0;
            this.btn_BanHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_BanHang.ForeColor = System.Drawing.Color.Navy;
            this.btn_BanHang.IconChar = FontAwesome.Sharp.IconChar.CartArrowDown;
            this.btn_BanHang.IconColor = System.Drawing.Color.Navy;
            this.btn_BanHang.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_BanHang.IconSize = 32;
            this.btn_BanHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_BanHang.Location = new System.Drawing.Point(0, 210);
            this.btn_BanHang.Name = "btn_BanHang";
            this.btn_BanHang.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btn_BanHang.Size = new System.Drawing.Size(220, 60);
            this.btn_BanHang.TabIndex = 2;
            this.btn_BanHang.Text = "Bán Hàng";
            this.btn_BanHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_BanHang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_BanHang.UseVisualStyleBackColor = true;
            this.btn_BanHang.Click += new System.EventHandler(this.btn_BanHang_Click);
            // 
            // btn_GiaoDienChinh
            // 
            this.btn_GiaoDienChinh.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_GiaoDienChinh.FlatAppearance.BorderSize = 0;
            this.btn_GiaoDienChinh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_GiaoDienChinh.ForeColor = System.Drawing.Color.Navy;
            this.btn_GiaoDienChinh.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.btn_GiaoDienChinh.IconColor = System.Drawing.Color.Navy;
            this.btn_GiaoDienChinh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_GiaoDienChinh.IconSize = 32;
            this.btn_GiaoDienChinh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_GiaoDienChinh.Location = new System.Drawing.Point(0, 150);
            this.btn_GiaoDienChinh.Name = "btn_GiaoDienChinh";
            this.btn_GiaoDienChinh.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btn_GiaoDienChinh.Size = new System.Drawing.Size(220, 60);
            this.btn_GiaoDienChinh.TabIndex = 1;
            this.btn_GiaoDienChinh.Text = "Giao Diện Chính";
            this.btn_GiaoDienChinh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_GiaoDienChinh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_GiaoDienChinh.UseVisualStyleBackColor = true;
            this.btn_GiaoDienChinh.Click += new System.EventHandler(this.btn_GiaoDienChinh_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_Home);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 150);
            this.panel2.TabIndex = 0;
            // 
            // btn_Home
            // 
            this.btn_Home.Image = ((System.Drawing.Image)(resources.GetObject("btn_Home.Image")));
            this.btn_Home.Location = new System.Drawing.Point(12, 28);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Size = new System.Drawing.Size(195, 98);
            this.btn_Home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Home.TabIndex = 0;
            this.btn_Home.TabStop = false;
            this.btn_Home.Click += new System.EventHandler(this.btn_Home_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.iconPictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(220, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(996, 75);
            this.panel1.TabIndex = 1;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.Teal;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.Navy;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconPictureBox1.IconColor = System.Drawing.Color.Navy;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 55;
            this.iconPictureBox1.Location = new System.Drawing.Point(6, 12);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(55, 59);
            this.iconPictureBox1.TabIndex = 0;
            this.iconPictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(220, 75);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(996, 580);
            this.panel3.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(996, 580);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Frm_GiaoDien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 655);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PanelMenu);
            this.Name = "Frm_GiaoDien";
            this.Text = "Form1";
            this.PanelMenu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_Home)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelMenu;
        private FontAwesome.Sharp.IconButton btn_GiaoDienChinh;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btn_BanHang;
        private FontAwesome.Sharp.IconButton btn_QuanLy;
        private FontAwesome.Sharp.IconButton btn_NhapHang;
        private FontAwesome.Sharp.IconButton btn_SanPham;
        private FontAwesome.Sharp.IconButton btn_NhanVien;
        private System.Windows.Forms.PictureBox btn_Home;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

