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
            _busHoaDonChiTiets = (from x in _busHoaDonChiTiets
                    group x by new
                    {
                        x.TenSanPham,
                        x.BarCode,
                        x.SoLuong,
                        x.DonGia,
                        x.GhiChu,
                        x.Id,
                        x.MaHoaDon,
                        x.NgayXuat,
                        x.ThanhTien,
                        
                    }
                    into g
                    select new BUS_HoaDonChiTiet()
                    {
                        TenSanPham = Convert.ToString(g.Count(c=>c.TenSanPham == c.TenSanPham)),
                        BarCode = g.Key.BarCode,
                        DonGia = g.Key.DonGia,
                        GhiChu = g.Key.GhiChu,
                        NgayXuat = g.Key.NgayXuat,
                        ThanhTien = g.Key.ThanhTien,
                        MaHoaDon = g.Key.MaHoaDon,
                        SoLuong = g.Sum(c=>c.SoLuong),
                        

                    }
                ).ToList();
           return _busHoaDonChiTiets;
        }
    }
}
