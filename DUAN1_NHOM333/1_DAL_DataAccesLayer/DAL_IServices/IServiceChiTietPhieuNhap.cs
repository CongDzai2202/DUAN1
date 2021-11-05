using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAccesLayer.Entities;

namespace _1_DAL_DataAccesLayer.DAL_IServices
{
    public interface IServiceChiTietPhieuNhap
    {
        public string ThemCTPN(CHITIETPHIEUNHAP ctpn);
        public string SuaCTPN(CHITIETPHIEUNHAP ctpn);
        public string XoaCTPN(CHITIETPHIEUNHAP ctpn);
        public string LuuCTPN();
        public List<CHITIETPHIEUNHAP> GetLstChiTietPhieuNhaps();
    }
}
