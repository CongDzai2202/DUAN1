using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace _3_GUI_PresentationLayer
{
    public partial class Frm_GiaoDien : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        public bool TT = false;
        public Frm_GiaoDien()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 10);
            PanelMenu.Controls.Add(leftBorderBtn);
            ChucVu();
            btn_LoaiHang.Visible = false;
            btn_NhaCungCap.Visible = false;
            btn_xuatxu.Visible = false;
            btn_Chucvu.Visible = false;
           
        }
        public void TrangThai(bool TrangThai)
        {
            TT = TrangThai;
            TT = TrangThai;
            //MessageBox.Show(TT.ToString());
        }
        void ChucVu()
        {
            //if(TT == false)
            //{
            //    btn_NhanVien.Enabled = false;
            //}
        }
        public struct RGBColor
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn!=null)
            {
                DisableButton();
                currentBtn = (IconButton) senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextAboveImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
            }
        }

        private void DisableButton()
        {
            if (currentBtn!=null)
            {
               
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_BanHang_Click(object sender, EventArgs e)
        {
            ActivateButton(sender,RGBColor.color1);
            //OpenChildForm(new Frm_BanHang());
            Frm_BanHang bh = new Frm_BanHang();
            this.Hide();
            bh.Show();
            

        }

        private void btn_NhanVien_Click(object sender, EventArgs e)
        {
            if (TT == true)
            {
                ActivateButton(sender, RGBColor.color2);
                OpenChildForm(new Frm_NhanVien());
            }
            else
            {
                MessageBox.Show("Tài Khoản Của Bạn Không Thể Thực Hiện Chức Năng Này", "Thông Báo");
            }

        }

        private void btn_SanPham_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColor.color3);
            Frm_ThongTinSanPham sp = new Frm_ThongTinSanPham();
            this.Hide();
            sp.Show();
        }

        private void btn_NhapHang_Click(object sender, EventArgs e)
        {
            if (TT == true)
            {
                ActivateButton(sender, RGBColor.color3);
                OpenChildForm(new Frm_NhapKho());
            }

        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
        }

        private void btn_GiaoDienChinh_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColor.color5);
            Frm_ThongKe tk = new Frm_ThongKe();
            this.Hide();
            tk.Show();
        }

        private void btn_QuanLy_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColor.color6);
            btn_LoaiHang.Visible = true;
            btn_NhaCungCap.Visible = true;
            btn_xuatxu.Visible = true;
            //btn_Chucvu.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
           // lblTitleChildForm.Text = childForm.Text;
        }

        private void btn_NhaCungCap_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColor.color6);
            OpenChildForm(new Frm_QuanLiNCC());
            
        }

        private void btn_xuatxu_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColor.color6);
            OpenChildForm(new Frm_XuatXu());
        }

        private void btn_LoaiHang_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColor.color6);
            OpenChildForm(new Frm_LoaiHang());
        }

        private void btn_Chucvu_Click(object sender, EventArgs e)
        {
            //ActivateButton(sender, RGBColor.color6);
            //OpenChildForm(new Frm_());
        }
    }
}
