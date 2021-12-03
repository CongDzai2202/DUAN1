using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAccesLayer.DAL_IServices;
using _1_DAL_DataAccesLayer.DAL_Services;
using _1_DAL_DataAccesLayer.Models;
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
        public List<HoaDonChiTiet> getLstHoaDonChiTietBUS()
        {
            return _iServiceHoaDonChiTiet.GetHoaDonChiTiets();
        }

        public string ThemHDCT(HoaDonChiTiet hdct)
        {
            return _iServiceHoaDonChiTiet.ThemHDCT(hdct);
        }

        public string SuaHDCT(HoaDonChiTiet hdct)
        {
            return _iServiceHoaDonChiTiet.SuaHDCT(hdct);
        }

        public string XoaHDCT(string mhdct)
        {
            return _iServiceHoaDonChiTiet.XoaHDCT(mhdct);
        }

        public string Luu()
        {
            return _iServiceHoaDonChiTiet.LuuHDCT();
        }

        public void GetLstFromDB()
        {
            _iServiceHoaDonChiTiet.GetLstFromDB();
        }
    }
}
