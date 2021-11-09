using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAccesLayer.Models;

namespace _2_BUS_BusinessLayer.BUS_IServices
{
    public interface IServiceQLHoaDon
    {
        List<HoaDon> getLstHoaDonBUS();
        public string ThemHD(HoaDon hd);
        public string SuaHD(HoaDon hd);
        public string XoaHD(HoaDon hd);
        public string LuuHD();
    }
}
