using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAccesLayer.Models;
using _1_DAL_DataAccesLayer.Models;

namespace _1_DAL_DataAccesLayer.DAL_IServices
{
    public interface IServiceChiTietPhieuNhap
    {
        public string ThemCTPN(PhieuNhapChiTiet ctpn);
        public string SuaCTPN(PhieuNhapChiTiet ctpn);
        public string XoaCTPN(PhieuNhapChiTiet ctpn);
        public string LuuCTPN();
        public List<PhieuNhapChiTiet> GetLstChiTietPhieuNhaps();
    }
}
