using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAccesLayer.Models;

namespace _1_DAL_DataAccesLayer.DAL_IServices
{
    public interface IServiceNhanVien
    {
        public string ThemNV(NhanVien nv);
        public string SuaNV(NhanVien nv);
        public string XoaNV(NhanVien nv);
        public List<NhanVien> GetLstNhanVien();
    }
}
