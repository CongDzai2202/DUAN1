using _2_BUS_BusinessLayer.BUS_IServices;
using _2_BUS_BusinessLayer.BUS_Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_GUI_PresentationLayer
{
    public partial class Frm_DangNhap : Form
    {
        public string key;
        public string pass;
        private IServiceDangNhap _iServiceDangNhap;
        public Frm_DangNhap()
        {
            _iServiceDangNhap = new ServiceDangNhap();
            pass = "";
            key = "";
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        public string Encrypt(string toEncrypt)
        {
            bool useHashing = true;
            byte[] keyArray;
            byte[] toEncryptArray = UTF8Encoding.UTF8.GetBytes(toEncrypt);

            if (useHashing)
            {
                MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
                keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
            }
            else
                keyArray = UTF8Encoding.UTF8.GetBytes(key);

            TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
            tdes.Key = keyArray;
            tdes.Mode = CipherMode.ECB;
            tdes.Padding = PaddingMode.PKCS7;

            ICryptoTransform cTransform = tdes.CreateEncryptor();
            byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);

            return Convert.ToBase64String(resultArray, 0, resultArray.Length);
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            if (_iServiceDangNhap.KiemTraTKMK(txt_sdt.Text, txt_makhau.Text, 1) == true)
            {
                MessageBox.Show("Đăng nhập thành công", "Thông báo");
                this.Hide();
                Frm_GiaoDien gd = new Frm_GiaoDien();
                gd.TrangThai(true);
                gd.Show();
            }
            else if(_iServiceDangNhap.KiemTraTKMK(txt_sdt.Text, txt_makhau.Text, 0) == true)
            {
                MessageBox.Show("Đăng nhập thành công", "Thông báo");
                this.Hide();
                Frm_GiaoDien gd = new Frm_GiaoDien();
                gd.TrangThai(false);
                gd.Show();
            }
            else
            {
                MessageBox.Show("Thông Tin Tài Khoản Hoặc Mật Khẩu Không Chính Xác", "Thông Báo");
            }
        }
    }
}
