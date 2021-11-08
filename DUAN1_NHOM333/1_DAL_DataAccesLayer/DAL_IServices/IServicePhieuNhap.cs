using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAccesLayer.Models;

namespace _1_DAL_DataAccesLayer.DAL_IServices
{
    public interface IServicePhieuNhap
    {
        public string ThemPN(PhieuNhap pn);
        public string SuaPN(PhieuNhap pn);
        public string XoaPN(PhieuNhap pn);
        public string LuuPN();
        public List<PhieuNhap> GetLstPhieunhaps();
    }
}
