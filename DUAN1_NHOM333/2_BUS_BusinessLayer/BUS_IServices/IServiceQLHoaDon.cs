using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAccesLayer.Entities;

namespace _2_BUS_BusinessLayer.BUS_IServices
{
    public interface IServiceQLHoaDon
    {
        List<HOADON> getLstHoaDon();
        public string ThemHD(HOADON hd);
        public string SuaHD(HOADON hd);
        public string XoaHD(HOADON hd);
    }
}
