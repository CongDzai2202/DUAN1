using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAccesLayer.DAL_IServices;
using _1_DAL_DataAccesLayer.DAL_Services;
using _2_BUS_BusinessLayer.BUS_IServices;
using _2_BUS_BusinessLayer.BUS_Models;

namespace _2_BUS_BusinessLayer.BUS_Services
{
    public class ServiceQLHienThi: IServiceQLHienThi
    {
        private IServiceHoaDon _lstHoaDon;
        private IServiceHoaDonChiTiet _lstHoaDonChiTiet;
        private List<BUS_HoaDonChiTiet> _busHoaDonChiTiets;

        public ServiceQLHienThi()
        {
            _lstHoaDon = new ServiceHoaDon();
            _busHoaDonChiTiets = new List<BUS_HoaDonChiTiet>();
            _lstHoaDonChiTiet = new ServiceHoaDonChiTiet();
        }
        public List<BUS_HoaDonChiTiet> getLstBusHoaDonChiTiets()
        {
           // _busHoaDonChiTiets = (from x in _lstHoaDon.GetLstHoaDon() join a in _lstHoaDonChiTiet.GetHoaDonChiTiets() on x.MaHoaDon equals a.MaHoaDon 
           //         group a by new
           //         {
           //             a.TenSanPham,
           //             x.MaHoaDon
           //         }
           //         into g
           //             select new BUS_HoaDonChiTiet()
           //             {
           //
           //             }
           //         )
           return _busHoaDonChiTiets;
        }
    }
}
