using _2_BUS_BusinessLayer.BUS_Services;
using _2_BUS_BusinessLayer.BUS_Utilities;
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
    public partial class Frm_DoiMatKhau : Form
    {
        private ServiceDoiMatKhau _qldoiMK;
        
        public Frm_DoiMatKhau()
        {
            
            _qldoiMK = new ServiceDoiMatKhau();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            DialogResult dr = MessageBox.Show("Bạn có muốn đổi mật khẩu không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                if (tbx_MKcu.Text == "" || tbx_SĐT.Text == "" || tbx_MkMoi.Text == "" || tbx_NhapLaiMKmoi.Text == "")
                {
                    DialogResult dm = MessageBox.Show("Bạn phải điền đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (tbx_NhapLaiMKmoi.Text != tbx_MkMoi.Text)
                {
                    DialogResult dm = MessageBox.Show("Nhập lại mật khẩu mới không khớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(_qldoiMK.CapNhatPass(tbx_SĐT.Text, tbx_MKcu.Text,tbx_MkMoi.Text), "Thông báo");
                }
            }
        }
    }
}
