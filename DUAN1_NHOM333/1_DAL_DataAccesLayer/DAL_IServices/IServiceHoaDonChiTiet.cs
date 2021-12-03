using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAccesLayer.Models;

namespace _1_DAL_DataAccesLayer.DAL_IServices
{
    public interface IServiceHoaDonChiTiet
    {
        public string ThemHDCT(HoaDonChiTiet hdct);
        public string SuaHDCT(HoaDonChiTiet hdct);
        public string XoaHDCT(String mhdct);
        public string LuuHDCT();
        public List<HoaDonChiTiet> GetHoaDonChiTiets();
    }
}
