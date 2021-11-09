using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAccesLayer.Models;

namespace _2_BUS_BusinessLayer.BUS_IServices
{
    public interface IServiceQLLoaiHang
    {
        List<LoaiHang> GetLstLoaiSanPham();
        public string ThemHDCT(LoaiHang ld);
        public string SuaHDCT(LoaiHang lh);
        public string XoaHDCT(LoaiHang ld);
    }
}
