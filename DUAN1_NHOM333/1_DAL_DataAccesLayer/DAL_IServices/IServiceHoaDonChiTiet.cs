using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAccesLayer.Entities;

namespace _1_DAL_DataAccesLayer.DAL_IServices
{
    public interface IServiceHoaDonChiTiet
    {
        public string ThemHDCT(HOADONCHITIET hdct);
        public string SuaHDCT(HOADONCHITIET hdct);
        public string XoaHDCT(HOADONCHITIET hdct);
        public string LuuHDCT();
        public List<HOADONCHITIET> GetHoaDonChiTiets();
    }
}
