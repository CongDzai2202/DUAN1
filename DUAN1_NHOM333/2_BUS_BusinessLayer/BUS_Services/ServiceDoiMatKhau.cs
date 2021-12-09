using _1_DAL_DataAccesLayer.Models;
using _2_BUS_BusinessLayer.BUS_IServices;
using _2_BUS_BusinessLayer.BUS_Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS_BusinessLayer.BUS_Services
{
    public class ServiceDoiMatKhau

    {
        private ISevicesQLNhanVien qLNhanVien;
        private MaHoaMK _maHoaMK;
        public ServiceDoiMatKhau()
        {
            qLNhanVien = new ServiceQLNhanVien();
            _maHoaMK = new MaHoaMK();
            qLNhanVien.GetDataFromDB();
        }
     
        public string CapNhatPass(string sdt,string mk,string mkm)
        {
            NhanVien nv = qLNhanVien.GetLstNhanVien().Where(c => c.SoDienThoai == sdt && c.MatKhau == _maHoaMK.MaHoaMk(mk)).FirstOrDefault();
            if (qLNhanVien.GetLstNhanVien().Any(c => c.SoDienThoai == sdt && c.MatKhau == _maHoaMK.MaHoaMk(mk)))
            {
                nv.MatKhau = mkm;
                qLNhanVien.SuaNV(nv);
                return "Đổi mật khẩu thành công";
            }
            else
            {
                return "Mật khẩu hoặc số điện thoại không đúng";
            }
            

        }
    }
}
