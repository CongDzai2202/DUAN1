using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAccesLayer.DAL_IServices;
using _1_DAL_DataAccesLayer.DAL_Services;
using _1_DAL_DataAccesLayer.Entities;
using _2_BUS_BusinessLayer.BUS_IServices;

namespace _2_BUS_BusinessLayer.BUS_Services
{
    public class ServiceQLHoaDonChiTiet: IServiceQLHoaDonChiTiet
    {
        private IServiceHoaDonChiTiet _iServiceHoaDonChiTiet;

        public ServiceQLHoaDonChiTiet()
        {
            _iServiceHoaDonChiTiet = new ServiceHoaDonChiTiet();
        }
        public List<HOADONCHITIET> getLstHoaDonChiTiet()
        {
            return _iServiceHoaDonChiTiet.GetHoaDonChiTiets();
        }

        public string ThemHDCT(HOADONCHITIET hdct)
        {
            return _iServiceHoaDonChiTiet.ThemHDCT(hdct);
        }

        public string SuaHDCT(HOADONCHITIET hdct)
        {
            return _iServiceHoaDonChiTiet.SuaHDCT(hdct);
        }

        public string XoaHDCT(HOADONCHITIET hdct)
        {
            return _iServiceHoaDonChiTiet.XoaHDCT(hdct);
        }
    }
}
