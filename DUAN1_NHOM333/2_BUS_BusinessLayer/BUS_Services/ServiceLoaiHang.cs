using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAccesLayer.DAL_IServices;
using _1_DAL_DataAccesLayer.Models;
using _2_BUS_BusinessLayer.BUS_IServices;

namespace _2_BUS_BusinessLayer.BUS_Services
{
    public class ServiceLoaiHang: IServiceQLLoaiHang
    {
        private IServiceLoaiHang _iServiceLoaiHang;

        public ServiceLoaiHang()
        {
            _iServiceLoaiHang = new _1_DAL_DataAccesLayer.DAL_Services.ServiceLoaiHang();
        }
        public List<LoaiHang> GetLstLoaiSanPham()
        {
            return _iServiceLoaiHang.GetLstLoaiHang();
        }

        public string ThemHDCT(LoaiHang ld)
        {
            return _iServiceLoaiHang.ThemLH(ld);
        }

        public string SuaHDCT(LoaiHang lh)
        {
            return _iServiceLoaiHang.SuaLH(lh);
        }

        public string XoaHDCT(LoaiHang ld)
        {
            return _iServiceLoaiHang.XoaLH(ld);
        }
    }
}
