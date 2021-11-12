using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1_DAL_DataAccesLayer.Models
{
    [Table("ThongTinSanPham")]
    public partial class ThongTinSanPham
    {
        public ThongTinSanPham()
        {
            HoaDonChiTiets = new HashSet<HoaDonChiTiet>();
            PhieuNhapChiTiets = new HashSet<PhieuNhapChiTiet>();
        }

        [Column("ID")]
        public int Id { get; set; }
        [Key]
        [StringLength(50)]
        public string MaThongTin { get; set; }
        [StringLength(50)]
        public string TenSanPham { get; set; }
        public double? DonGia { get; set; }
        public int? SoLuong { get; set; }
        public double? TrongLuong { get; set; }
        [StringLength(50)]
        public string HinhAnh { get; set; }
        [StringLength(50)]
        public string Barcode { get; set; }
        [Required]
        [StringLength(50)]
        public string MaDonViTinh { get; set; }
        [Required]
        [StringLength(50)]
        public string MaLoaiHang { get; set; }
        [Required]
        [StringLength(50)]
        public string MaXuatXu { get; set; }
        [Required]
        [StringLength(50)]
        public string MaSanPham { get; set; }
        [StringLength(100)]
        public string MoTa { get; set; }
        public int? TrangThai { get; set; }

        [ForeignKey(nameof(MaDonViTinh))]
        [InverseProperty(nameof(DonViTinh.ThongTinSanPhams))]
        public virtual DonViTinh MaDonViTinhNavigation { get; set; }
        [ForeignKey(nameof(MaLoaiHang))]
        [InverseProperty(nameof(LoaiHang.ThongTinSanPhams))]
        public virtual LoaiHang MaLoaiHangNavigation { get; set; }
        [ForeignKey(nameof(MaSanPham))]
        [InverseProperty(nameof(SanPham.ThongTinSanPhams))]
        public virtual SanPham MaSanPhamNavigation { get; set; }
        [ForeignKey(nameof(MaXuatXu))]
        [InverseProperty(nameof(XuatXu.ThongTinSanPhams))]
        public virtual XuatXu MaXuatXuNavigation { get; set; }
        [InverseProperty(nameof(HoaDonChiTiet.MaThongTinNavigation))]
        public virtual ICollection<HoaDonChiTiet> HoaDonChiTiets { get; set; }
        [InverseProperty(nameof(PhieuNhapChiTiet.MaThongTinNavigation))]
        public virtual ICollection<PhieuNhapChiTiet> PhieuNhapChiTiets { get; set; }
    }
}
