using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS_BusinessLayer.BUS_Models
{
    public class Bus_ThongKe
    {
        public string MaHoaDon { get; set; }
        public string MaNhanVien { get; set; }
        public DateTime? NgayXuat { get; set; }
        public double? ThanhTien { get; set; }
        public int? TrangThai { get; set; }
        public string MaHoaDonChiTiet { get; set; }
        public string MaThongTin { get; set; }
        public string TenSanPham { get; set; }
        public double? DonGia { get; set; }
        public int SoLuong { get; set; }
    }
}
