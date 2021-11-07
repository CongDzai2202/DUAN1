using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAccesLayer.DAL_IServices;
using _1_DAL_DataAccesLayer.Entities;

namespace _2_BUS_BusinessLayer.BUS_IServices
{
    public interface IServiceQLHoaDonChiTiet
    {
        List<HOADONCHITIET> getLstHoaDonChiTiet();
        public string ThemHDCT(HOADONCHITIET hdct);
        public string SuaHDCT(HOADONCHITIET hdct);
        public string XoaHDCT(HOADONCHITIET hdct);
        public string Luu();

    }
}
