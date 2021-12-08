
namespace _3_GUI_PresentationLayer
{
    partial class Frm_ThongKe
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_TongTien = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cbx_nam = new System.Windows.Forms.CheckBox();
            this.cbx_thang = new System.Windows.Forms.CheckBox();
            this.cbx_Ngay = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.datetimeend = new System.Windows.Forms.DateTimePicker();
            this.datetimeStart = new System.Windows.Forms.DateTimePicker();
            this.rdb_ChuaThanhToan = new System.Windows.Forms.RadioButton();
            this.rdb_DTT = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgid_ChiTiet = new System.Windows.Forms.DataGridView();
            this.dgid_Data = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgid_ChiTiet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgid_Data)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1869, 94);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(799, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "Thống Kê Doanh Thu";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lb_TongTien);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.cbx_nam);
            this.groupBox1.Controls.Add(this.cbx_thang);
            this.groupBox1.Controls.Add(this.cbx_Ngay);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.datetimeend);
            this.groupBox1.Controls.Add(this.datetimeStart);
            this.groupBox1.Controls.Add(this.rdb_ChuaThanhToan);
            this.groupBox1.Controls.Add(this.rdb_DTT);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1869, 183);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(987, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 38);
            this.label5.TabIndex = 7;
            this.label5.Text = "Tổng Tiền : ";
            // 
            // lb_TongTien
            // 
            this.lb_TongTien.AutoSize = true;
            this.lb_TongTien.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_TongTien.ForeColor = System.Drawing.Color.Red;
            this.lb_TongTien.Location = new System.Drawing.Point(1173, 21);
            this.lb_TongTien.Name = "lb_TongTien";
            this.lb_TongTien.Size = new System.Drawing.Size(84, 38);
            this.lb_TongTien.TabIndex = 6;
            this.lb_TongTien.Text = "Tổng";
            this.lb_TongTien.Click += new System.EventHandler(this.lb_TongTien_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(797, 69);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 46);
            this.button1.TabIndex = 5;
            this.button1.Text = "Xác Nhận ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbx_nam
            // 
            this.cbx_nam.AutoSize = true;
            this.cbx_nam.Location = new System.Drawing.Point(411, 30);
            this.cbx_nam.Name = "cbx_nam";
            this.cbx_nam.Size = new System.Drawing.Size(120, 29);
            this.cbx_nam.TabIndex = 4;
            this.cbx_nam.Text = "Theo Năm";
            this.cbx_nam.UseVisualStyleBackColor = true;
            this.cbx_nam.CheckedChanged += new System.EventHandler(this.cbx_nam_CheckedChanged);
            // 
            // cbx_thang
            // 
            this.cbx_thang.AutoSize = true;
            this.cbx_thang.Location = new System.Drawing.Point(246, 30);
            this.cbx_thang.Name = "cbx_thang";
            this.cbx_thang.Size = new System.Drawing.Size(131, 29);
            this.cbx_thang.TabIndex = 4;
            this.cbx_thang.Text = "Theo Tháng";
            this.cbx_thang.UseVisualStyleBackColor = true;
            this.cbx_thang.CheckedChanged += new System.EventHandler(this.cbx_thang_CheckedChanged);
            // 
            // cbx_Ngay
            // 
            this.cbx_Ngay.AutoSize = true;
            this.cbx_Ngay.Location = new System.Drawing.Point(61, 30);
            this.cbx_Ngay.Name = "cbx_Ngay";
            this.cbx_Ngay.Size = new System.Drawing.Size(124, 29);
            this.cbx_Ngay.TabIndex = 4;
            this.cbx_Ngay.Text = "Theo Ngày";
            this.cbx_Ngay.UseVisualStyleBackColor = true;
            this.cbx_Ngay.CheckedChanged += new System.EventHandler(this.cbx_Ngay_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Trạng Thái : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(378, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Đến";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Từ";
            // 
            // datetimeend
            // 
            this.datetimeend.Location = new System.Drawing.Point(440, 75);
            this.datetimeend.Name = "datetimeend";
            this.datetimeend.Size = new System.Drawing.Size(300, 31);
            this.datetimeend.TabIndex = 1;
            // 
            // datetimeStart
            // 
            this.datetimeStart.Location = new System.Drawing.Point(61, 75);
            this.datetimeStart.Name = "datetimeStart";
            this.datetimeStart.Size = new System.Drawing.Size(300, 31);
            this.datetimeStart.TabIndex = 1;
            // 
            // rdb_ChuaThanhToan
            // 
            this.rdb_ChuaThanhToan.AutoSize = true;
            this.rdb_ChuaThanhToan.Location = new System.Drawing.Point(301, 139);
            this.rdb_ChuaThanhToan.Name = "rdb_ChuaThanhToan";
            this.rdb_ChuaThanhToan.Size = new System.Drawing.Size(173, 29);
            this.rdb_ChuaThanhToan.TabIndex = 0;
            this.rdb_ChuaThanhToan.Text = "Chưa Thanh Toán";
            this.rdb_ChuaThanhToan.UseVisualStyleBackColor = true;
            this.rdb_ChuaThanhToan.CheckedChanged += new System.EventHandler(this.rdb_ChuaThanhToan_CheckedChanged);
            // 
            // rdb_DTT
            // 
            this.rdb_DTT.AutoSize = true;
            this.rdb_DTT.Location = new System.Drawing.Point(137, 139);
            this.rdb_DTT.Name = "rdb_DTT";
            this.rdb_DTT.Size = new System.Drawing.Size(154, 29);
            this.rdb_DTT.TabIndex = 0;
            this.rdb_DTT.Text = "Đã Thanh Toán";
            this.rdb_DTT.UseVisualStyleBackColor = true;
            this.rdb_DTT.CheckedChanged += new System.EventHandler(this.rdb_DTT_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgid_ChiTiet);
            this.groupBox2.Controls.Add(this.dgid_Data);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 277);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1869, 773);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // dgid_ChiTiet
            // 
            this.dgid_ChiTiet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgid_ChiTiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgid_ChiTiet.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgid_ChiTiet.Location = new System.Drawing.Point(937, 27);
            this.dgid_ChiTiet.Name = "dgid_ChiTiet";
            this.dgid_ChiTiet.RowHeadersWidth = 62;
            this.dgid_ChiTiet.RowTemplate.Height = 33;
            this.dgid_ChiTiet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgid_ChiTiet.Size = new System.Drawing.Size(929, 743);
            this.dgid_ChiTiet.TabIndex = 1;
            this.dgid_ChiTiet.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgid_ChiTiet_CellClick);
            // 
            // dgid_Data
            // 
            this.dgid_Data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgid_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgid_Data.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgid_Data.Location = new System.Drawing.Point(3, 27);
            this.dgid_Data.Name = "dgid_Data";
            this.dgid_Data.RowHeadersWidth = 62;
            this.dgid_Data.RowTemplate.Height = 33;
            this.dgid_Data.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgid_Data.Size = new System.Drawing.Size(906, 743);
            this.dgid_Data.TabIndex = 0;
            this.dgid_Data.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgid_Data_CellClick);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Image = global::_3_GUI_PresentationLayer.Properties.Resources.out1;
            this.button2.Location = new System.Drawing.Point(1745, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(71, 48);
            this.button2.TabIndex = 5;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Frm_ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1869, 1050);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Frm_ThongKe";
            this.Text = "Frm_ThongKe";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgid_ChiTiet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgid_Data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbx_thang;
        private System.Windows.Forms.CheckBox cbx_Ngay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rdb_ChuaThanhToan;
        private System.Windows.Forms.RadioButton rdb_DTT;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgid_Data;
        private System.Windows.Forms.CheckBox cbx_nam;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dgid_ChiTiet;
        private System.Windows.Forms.Label lb_TongTien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker datetimeend;
        private System.Windows.Forms.DateTimePicker datetimeStart;
        private System.Windows.Forms.Button button2;
    }
}