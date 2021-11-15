using _1_DAL_DataAccesLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS_BusinessLayer.BUS_Models
{
    public class ViewNhapKho
    {
        public PhieuNhap Phieunhap { get; set; }
        public PhieuNhapChiTiet Phieunhapchitiet { get; set; }
        public NhaCungCap Nhacungcap { get; set; }
        public ThongTinSanPham ThongtinSP { get; set; }
        
        public ViewNhapKho()
        {
            Phieunhap = new PhieuNhap();
            Phieunhapchitiet = new PhieuNhapChiTiet();
            Nhacungcap = new NhaCungCap();
            ThongtinSP = new ThongTinSanPham();
        }
        /*public ViewNhapKho(PhieuNhap phieuNhap, PhieuNhapChiTiet phieuNhapChiTiet,NhaCungCap nhaCungCap,ThongTinSanPham thongTinSanPham)
        {
            Phieunhap = phieuNhap;
            Phieunhapchitiet = phieuNhapChiTiet;
            Nhacungcap = nhaCungCap;
            ThongtinSP = thongTinSanPham;
        }*/
        public override bool Equals(object obj)
        {
            return obj is ViewNhapKho detail &&
                   EqualityComparer<NhaCungCap>.Default.Equals(Nhacungcap, detail.Nhacungcap) &&
                   EqualityComparer<PhieuNhap>.Default.Equals(Phieunhap, detail.Phieunhap) &&
                   EqualityComparer<PhieuNhapChiTiet>.Default.Equals(Phieunhapchitiet, detail.Phieunhapchitiet) &&
                   EqualityComparer<ThongTinSanPham>.Default.Equals(ThongtinSP, detail.ThongtinSP);
        }
    }
}
