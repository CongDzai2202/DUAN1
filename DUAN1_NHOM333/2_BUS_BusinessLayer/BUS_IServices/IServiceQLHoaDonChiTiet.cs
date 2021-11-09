using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAccesLayer.DAL_IServices;
using _1_DAL_DataAccesLayer.Models;

namespace _2_BUS_BusinessLayer.BUS_IServices
{
    public interface IServiceQLHoaDonChiTiet
    {
        List<HoaDonChiTiet> getLstHoaDonChiTietBUS();
        public string ThemHDCT(HoaDonChiTiet hdct);
        public string SuaHDCT(HoaDonChiTiet hdct);
        public string XoaHDCT(HoaDonChiTiet hdct);
        public string Luu();

    }
}
