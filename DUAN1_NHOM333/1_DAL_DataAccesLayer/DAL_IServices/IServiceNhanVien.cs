using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAccesLayer.Entities;

namespace _1_DAL_DataAccesLayer.DAL_IServices
{
    public interface IServiceNhanVien
    {
        public string ThemNV(NHANVIEN nv);
        public string SuaNV(NHANVIEN nv);
        public string XoaNV(NHANVIEN nv);
        public List<NHANVIEN> GetLstNhanVien();
    }
}
