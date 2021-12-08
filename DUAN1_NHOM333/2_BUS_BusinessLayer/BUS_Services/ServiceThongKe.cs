using _1_DAL_DataAccesLayer.DAL_IServices;
using _1_DAL_DataAccesLayer.DAL_Services;
using _2_BUS_BusinessLayer.BUS_IServices;
using _2_BUS_BusinessLayer.BUS_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS_BusinessLayer.BUS_Services
{
    class ServiceThongKe : IServiceThongKe
    {
        private IServiceHoaDon _iServiceQlHoaDon;
        private IServiceHoaDonChiTiet _iServiceQlHoaDonChiTiet;
        private List<Bus_ThongKe> _busThongKe;
        public ServiceThongKe()
        {
            _iServiceQlHoaDon = new ServiceHoaDon();
            _busThongKe = new List<Bus_ThongKe>();
            _iServiceQlHoaDonChiTiet = new ServiceHoaDonChiTiet();
        }
        public List<Bus_ThongKe> GetLstBusThongKe()
        {
            _busThongKe = (from a in _iServiceQlHoaDon.GetLstHoaDon()
                           join b in _iServiceQlHoaDonChiTiet.GetHoaDonChiTiets() on a.MaHoaDon equals b.MaHoaDon
                                  group a by new
                                  {

                                      a.MaHoaDon,
                                      a.NgayXuat,
                                      b.TenSanPham,
                                      a.MaNhanVien,
                                      b.DonGia,
                                      b.SoLuong,
                                      a.TrangThai,
                                      a.ThanhTien

                                  }
                into g
                                  select new Bus_ThongKe()
                                  {
                                      TenSanPham = g.Key.TenSanPham,
                                      MaNhanVien = g.Key.MaNhanVien,
                                      MaHoaDon = g.Key.MaHoaDon,
                                      DonGia = g.Key.DonGia,
                                      
                                      TrangThai = g.Key.TrangThai,
                                      ThanhTien = g.Key.ThanhTien,
                                      
                                  }).ToList();

            return _busThongKe;
        }
    }
}
