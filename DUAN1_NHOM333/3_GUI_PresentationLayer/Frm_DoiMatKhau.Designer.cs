
namespace _3_GUI_PresentationLayer
{
    partial class Frm_DoiMatKhau
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
            this.tbx_MKcu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbx_SĐT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbx_MkMoi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbx_NhapLaiMKmoi = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mật khẩu cũ:";
            // 
            // tbx_MKcu
            // 
            this.tbx_MKcu.Location = new System.Drawing.Point(187, 96);
            this.tbx_MKcu.Name = "tbx_MKcu";
            this.tbx_MKcu.Size = new System.Drawing.Size(162, 27);
            this.tbx_MKcu.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Số điện thoại:";
            // 
            // tbx_SĐT
            // 
            this.tbx_SĐT.Location = new System.Drawing.Point(187, 60);
            this.tbx_SĐT.Name = "tbx_SĐT";
            this.tbx_SĐT.Size = new System.Drawing.Size(162, 27);
            this.tbx_SĐT.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mật khẩu mới:";
            // 
            // tbx_MkMoi
            // 
            this.tbx_MkMoi.Location = new System.Drawing.Point(187, 136);
            this.tbx_MkMoi.Name = "tbx_MkMoi";
            this.tbx_MkMoi.Size = new System.Drawing.Size(162, 27);
            this.tbx_MkMoi.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nhập lại mật khẩu mới:";
            // 
            // tbx_NhapLaiMKmoi
            // 
            this.tbx_NhapLaiMKmoi.Location = new System.Drawing.Point(187, 176);
            this.tbx_NhapLaiMKmoi.Name = "tbx_NhapLaiMKmoi";
            this.tbx_NhapLaiMKmoi.Size = new System.Drawing.Size(162, 27);
            this.tbx_NhapLaiMKmoi.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(137, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 47);
            this.button1.TabIndex = 8;
            this.button1.Text = "Xác nhận";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label5.Location = new System.Drawing.Point(114, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 31);
            this.label5.TabIndex = 10;
            this.label5.Text = "Đổi mật khẩu";
            // 
            // Frm_DoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(388, 307);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbx_NhapLaiMKmoi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbx_MkMoi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbx_SĐT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbx_MKcu);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Name = "Frm_DoiMatKhau";
            this.Text = "Frm_DoiMatKhau";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbx_MKcu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbx_SĐT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbx_MkMoi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbx_NhapLaiMKmoi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
    }
}