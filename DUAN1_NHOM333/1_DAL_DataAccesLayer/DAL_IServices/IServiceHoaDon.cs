using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAccesLayer.Entities;

namespace _1_DAL_DataAccesLayer.DAL_IServices
{
    public interface IServiceHoaDon
    {
        public string ThemHD(HOADON hd);
        public string SuaHD(HOADON hd);
        public string XoaHD(HOADON hd);
        public string LuuHD();
        public List<HOADON> GetLstHoaDon();
    } 
}
