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
        public Frm_GiaoDien()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 10);
            PanelMenu.Controls.Add(leftBorderBtn);
           
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
        }

        private void btn_NhanVien_Click(object sender, EventArgs e)
        {
            ActivateButton(sender,RGBColor.color2);

        }

        private void btn_SanPham_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColor.color3);
        }

        private void btn_NhapHang_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColor.color4);
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
        }

        private void btn_QuanLy_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColor.color6);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
