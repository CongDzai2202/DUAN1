using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS_BusinessLayer.BUS_Models
{
    public class BUS_HoaDonChiTiet
    {
        public int Id { get; set; }
        public string MaHoaDonChiTiet { get; set; }
        public string MaHoaDon { get; set; }
        public string TenSanPham { get; set; }
        public double? DonGia { get; set; }
        public int? SoLuong { get; set; }
        public string BarCode { get; set; }
        public string GhiChu { get; set; }
        public int? TrangThai { get; set; }
        public string MaNhanVien { get; set; }
        public DateTime? NgayXuat { get; set; }
        public double? ThanhTien { get; set; }
    }
}
