using _1_DAL_DataAccesLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS_BusinessLayer.BUS_IServices
{
    public interface IServiceDangNhap
    {
        List<NhanVien> GetLstNhanVien();
        bool KiemTraTKMK(string sdt, string mk, int tt);
        bool KiemTraTKMK1(string sdt, string mk, int tt);
        string LuuMatKhauMoi(NhanVien nhanvien);

    }
}
