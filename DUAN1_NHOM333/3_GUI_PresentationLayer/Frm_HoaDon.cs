using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_GUI_PresentationLayer
{
    public partial class Frm_HoaDon : Form
    {
        public string Ten1;
        public string Ten2;
        public string Ten3;
        public string Ten4;
        public string Ten5;
        public string Ten6;
        public string Ten7;
        public string Ten8;
        public string Ten9;
        public string Ten10;
        public string Ten11;
        public string MaHoaDon;
        public string TongTien1;
        public Frm_HoaDon()
        {
            InitializeComponent();
            InHD();
            

        }
        public void Layten(string ten1, string ten2, string ten3, string ten4, string ten5, string ten6, string ten7, string ten8, string ten9, string ten10, string ten11)
        {
            Ten1 = ten1;
            Ten2 = ten2;
            Ten3 = ten3;
            Ten4 = ten4;
            Ten5 = ten5;
            Ten6 = ten6;
            Ten7 = ten7;
            Ten8 = ten8;
            Ten9 = ten9;
            Ten10 = ten10;
            Ten11 = ten11;
           
        }
        public void LayMHDTIEN(string Mhd,string TongTien)
        {
            MaHoaDon = Mhd;
            TongTien1 = TongTien;
        }
        private void label6_Click(object sender, EventArgs e)
        {

        }
        void InHD()
        {
            lb_tensp1.Text = Ten1 + ",";
            lb_tensp2.Text = Ten2 + ",";
            lb_tensp3.Text = Ten3 + ",";
            lb_tensp4.Text = Ten4 + ",";
            lb_tensp5.Text = Ten5 + ",";
            lb_tensp6.Text = Ten6 + ",";
            lb_tensp7.Text = Ten7 + ",";
            lb_tensp8.Text = Ten8 + ",";
            lb_tensp9.Text = Ten9 + ",";
            lb_tensp10.Text = Ten10 + ",";
            lb_tensp11.Text = Ten11 + ",";
            lb_Mhd.Text = MaHoaDon;
            lb_TongTien.Text = TongTien1;

        }
        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
