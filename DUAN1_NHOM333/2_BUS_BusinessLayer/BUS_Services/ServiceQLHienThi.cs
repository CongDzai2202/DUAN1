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
        private IServiceHoaDon _iServiceQlHoaDon;
        private IServiceHoaDonChiTiet _iServiceQlHoaDonChiTiet;
        private IServiceThongTinHangHoa __iServiceQlctSanPham;
        private List<BUS_HoaDonChiTiet> _busHoaDonChiTiets;

        public ServiceQLHienThi()
        {
            __iServiceQlctSanPham = new ServiceThongTinHangHoa();
            _iServiceQlHoaDon = new ServiceHoaDon();
            _busHoaDonChiTiets = new List<BUS_HoaDonChiTiet>();
            _iServiceQlHoaDonChiTiet = new ServiceHoaDonChiTiet();
        }
        public List<BUS_HoaDonChiTiet> getLstBusHoaDonChiTiets()
        {
            _busHoaDonChiTiets = (from a in __iServiceQlctSanPham.GetLstTTHangHoas()
                join b in _iServiceQlHoaDonChiTiet.GetHoaDonChiTiets() on a.MaThongTin equals b.MaThongTin
                join c in _iServiceQlHoaDon.GetLstHoaDon() on b.MaHoaDon equals c.MaHoaDon
                group a by new
                {


                    a.TenSanPham,
                    a.Barcode,
                    c.MaHoaDon,
                    a.DonGia,
                    a.SoLuong,
                    b.TrangThai,
                    c.ThanhTien

                }
                into g
                select new BUS_HoaDonChiTiet()
                {
                    TenSanPham = g.Key.TenSanPham,
                    BarCode = g.Key.Barcode,
                    MaHoaDon = g.Key.MaHoaDon,
                    DonGia = g.Key.DonGia,
                    SoLuong = g.Key.SoLuong,
                    TrangThai = g.Key.TrangThai,
                    ThanhTien = g.Key.ThanhTien,
                    // ThanhTien = g.
                }).ToList();
           
            return _busHoaDonChiTiets;
        }

        
    }
}
