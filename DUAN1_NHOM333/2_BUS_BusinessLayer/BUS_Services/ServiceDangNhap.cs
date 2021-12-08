using _1_DAL_DataAccesLayer.DAL_IServices;
using _1_DAL_DataAccesLayer.DAL_Services;
using _1_DAL_DataAccesLayer.Models;
using _2_BUS_BusinessLayer.BUS_IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS_BusinessLayer.BUS_Services
{
    public class ServiceDangNhap : IServiceDangNhap
    {
        IServiceNhanVien _iServiceNhanVien;
        List<NhanVien> _lstNhanVien;
        public ServiceDangNhap()
        {
            _iServiceNhanVien = new ServiceNhanVien();
            _lstNhanVien = _iServiceNhanVien.GetLstNhanVien();
        }
        public List<NhanVien> GetLstNhanVien()
        {
            return _iServiceNhanVien.GetLstNhanVien();
        }

        public bool KiemTraTKMK(string sdt, string mk,int tt)
        {
            if(_lstNhanVien.Any(c=>c.SoDienThoai == sdt && c.MatKhau == mk && c.TrangThai == 0))
            {
                return true;
            }
            return false;
        }

        public bool KiemTraTKMK1(string sdt, string mk, int tt)
        {
            if (_lstNhanVien.Any(c => c.SoDienThoai == sdt && c.MatKhau == mk && c.TrangThai == 1))
            {
                return true;
            }
            return false;
        }

        public string LuuMatKhauMoi(NhanVien nhanvien)
        {
            return _iServiceNhanVien.SuaNV(nhanvien);
        }
    }
}
