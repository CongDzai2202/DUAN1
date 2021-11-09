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
    public class ServiceQLHoaDon: IServiceQLHoaDon
    {
        private IServiceHoaDon _iServiceHoaDon;

        public ServiceQLHoaDon()
        {
            _iServiceHoaDon = new ServiceHoaDon();
        }
        public List<HoaDon> getLstHoaDonBUS()
        {
            return _iServiceHoaDon.GetLstHoaDon();
        }
        
        public string ThemHD(HoaDon hd)
        {
            return _iServiceHoaDon.ThemHD(hd);
            
        }

        public string SuaHD(HoaDon hd)
        {
            return _iServiceHoaDon.SuaHD(hd);
        }

        public string XoaHD(HoaDon hd)
        {
            return _iServiceHoaDon.XoaHD(hd);
        }

        public string LuuHD()
        {
            return _iServiceHoaDon.LuuHD();
        }
    }
}
