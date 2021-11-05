using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAccesLayer.Entities;

namespace _1_DAL_DataAccesLayer.DAL_IServices
{
    public interface IServicePhieuNhap
    {
        public string ThemPN(PHIEUNHAP pn);
        public string SuaPN(PHIEUNHAP pn);
        public string XoaPN(PHIEUNHAP pn);
        public string LuuPN();
        public List<PHIEUNHAP> GetLstPhieunhaps();
    }
}
