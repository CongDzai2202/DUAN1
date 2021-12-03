using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAccesLayer.Models;

namespace _1_DAL_DataAccesLayer.DAL_IServices
{
    public interface IServiceHoaDon
    {
        public string ThemHD(HoaDon hd);
        public string SuaHD(HoaDon hd);
        public string XoaHD(HoaDon hd);
        public string LuuHD();
        public List<HoaDon> GetLstHoaDon();
        public void GetLstFromDB();
    } 
}
