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
    public class ServiceQLHoaDon: IServiceQLHoaDon
    {
        private IServiceHoaDon _iServiceHoaDon;

        public ServiceQLHoaDon()
        {
            _iServiceHoaDon = new ServiceHoaDon();
        }
        public List<HOADON> getLstHoaDon()
        {
            return _iServiceHoaDon.GetLstHoaDon();
        }

        public string ThemHD(HOADON hd)
        {
            return _iServiceHoaDon.ThemHD(hd);
        }

        public string SuaHD(HOADON hd)
        {
            return _iServiceHoaDon.SuaHD(hd);
        }

        public string XoaHD(HOADON hd)
        {
            return _iServiceHoaDon.XoaHD(hd);
        }
    }
}
