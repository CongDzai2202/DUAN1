
namespace _3_GUI_PresentationLayer
{
    partial class Frm_QuanLiNCC
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
            this.dgv_NhaCungCap = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_luu = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_nhaplai = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.txt_SDT = new System.Windows.Forms.TextBox();
            this.txt_MaNcc = new System.Windows.Forms.TextBox();
            this.txt_TenNcc = new System.Windows.Forms.TextBox();
            this.txt_diachi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NhaCungCap)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_NhaCungCap);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 318);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(1060, 312);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // dgv_NhaCungCap
            // 
            this.dgv_NhaCungCap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_NhaCungCap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_NhaCungCap.Location = new System.Drawing.Point(4, 27);
            this.dgv_NhaCungCap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgv_NhaCungCap.Name = "dgv_NhaCungCap";
            this.dgv_NhaCungCap.RowTemplate.Height = 25;
            this.dgv_NhaCungCap.Size = new System.Drawing.Size(1052, 280);
            this.dgv_NhaCungCap.TabIndex = 0;
            this.dgv_NhaCungCap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_NhaCungCap_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_luu);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btn_nhaplai);
            this.groupBox2.Controls.Add(this.btn_Them);
            this.groupBox2.Controls.Add(this.btn_sua);
            this.groupBox2.Controls.Add(this.txt_SDT);
            this.groupBox2.Controls.Add(this.txt_MaNcc);
            this.groupBox2.Controls.Add(this.txt_TenNcc);
            this.groupBox2.Controls.Add(this.txt_diachi);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.ForeColor = System.Drawing.Color.Yellow;
            this.groupBox2.Location = new System.Drawing.Point(4, 16);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(800, 310);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin Chi Tiết";
            // 
            // btn_luu
            // 
            this.btn_luu.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_luu.Location = new System.Drawing.Point(495, 252);
            this.btn_luu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(117, 40);
            this.btn_luu.TabIndex = 9;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.UseVisualStyleBackColor = false;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(450, 166);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 21);
            this.label5.TabIndex = 13;
            this.label5.Text = "Địa Chỉ:";
            // 
            // btn_nhaplai
            // 
            this.btn_nhaplai.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_nhaplai.Location = new System.Drawing.Point(645, 252);
            this.btn_nhaplai.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_nhaplai.Name = "btn_nhaplai";
            this.btn_nhaplai.Size = new System.Drawing.Size(117, 40);
            this.btn_nhaplai.TabIndex = 10;
            this.btn_nhaplai.Text = "Nhập Lại";
            this.btn_nhaplai.UseVisualStyleBackColor = false;
            this.btn_nhaplai.Click += new System.EventHandler(this.btn_nhaplai_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_Them.Location = new System.Drawing.Point(184, 252);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(117, 40);
            this.btn_Them.TabIndex = 7;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_sua.Location = new System.Drawing.Point(342, 252);
            this.btn_sua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(117, 40);
            this.btn_sua.TabIndex = 8;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = false;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // txt_SDT
            // 
            this.txt_SDT.Location = new System.Drawing.Point(538, 61);
            this.txt_SDT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Size = new System.Drawing.Size(223, 29);
            this.txt_SDT.TabIndex = 4;
            // 
            // txt_MaNcc
            // 
            this.txt_MaNcc.Enabled = false;
            this.txt_MaNcc.Location = new System.Drawing.Point(126, 61);
            this.txt_MaNcc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_MaNcc.Name = "txt_MaNcc";
            this.txt_MaNcc.Size = new System.Drawing.Size(223, 29);
            this.txt_MaNcc.TabIndex = 2;
            // 
            // txt_TenNcc
            // 
            this.txt_TenNcc.Location = new System.Drawing.Point(126, 163);
            this.txt_TenNcc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_TenNcc.Name = "txt_TenNcc";
            this.txt_TenNcc.Size = new System.Drawing.Size(223, 29);
            this.txt_TenNcc.TabIndex = 3;
            // 
            // txt_diachi
            // 
            this.txt_diachi.Location = new System.Drawing.Point(538, 163);
            this.txt_diachi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.Size = new System.Drawing.Size(223, 29);
            this.txt_diachi.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 166);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tên NCC:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(392, 66);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số Điện Thoại:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã NCC:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tìm Kiếm:";
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(20, 103);
            this.txt_search.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(199, 29);
            this.txt_search.TabIndex = 6;
            // 
            // btn_thoat
            // 
            this.btn_thoat.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_thoat.Location = new System.Drawing.Point(64, 252);
            this.btn_thoat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(117, 40);
            this.btn_thoat.TabIndex = 12;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = false;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_search.Location = new System.Drawing.Point(64, 189);
            this.btn_search.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(117, 40);
            this.btn_search.TabIndex = 11;
            this.btn_search.Text = "Tìm Kiếm";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_search);
            this.groupBox3.Controls.Add(this.btn_thoat);
            this.groupBox3.Controls.Add(this.txt_search);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.ForeColor = System.Drawing.Color.Yellow;
            this.groupBox3.Location = new System.Drawing.Point(806, 16);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(244, 310);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chức Năng";
            // 
            // Frm_QuanLiNCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1060, 630);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Frm_QuanLiNCC";
            this.Text = "Frm_QuanLiNCC";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NhaCungCap)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_NhaCungCap;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_nhaplai;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.TextBox txt_SDT;
        private System.Windows.Forms.TextBox txt_MaNcc;
        private System.Windows.Forms.TextBox txt_TenNcc;
        private System.Windows.Forms.TextBox txt_diachi;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_luu;
    }
}