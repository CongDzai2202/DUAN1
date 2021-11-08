using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAccesLayer.Models;

namespace _2_BUS_BusinessLayer.BUS_IServices
{
    public interface IServiceQLCTSanPham
    {
        List<ThongTinSanPham> GetLstThongTinSanPhams();
        public string ThemSP(ThongTinSanPham hh);
        public string SuaSP(ThongTinSanPham hh);
        public string XoaSP(ThongTinSanPham hh);
        public string LuuSP();
        
    }
}
