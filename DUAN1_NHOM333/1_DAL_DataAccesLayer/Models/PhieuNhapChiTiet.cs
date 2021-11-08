using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1_DAL_DataAccesLayer.Models
{
    [Table("PhieuNhapChiTiet")]
    public partial class PhieuNhapChiTiet
    {
        [Column("ID")]
        public int Id { get; set; }
        [Key]
        [Column("MaCTPhieuNhap")]
        [StringLength(50)]
        public string MaCtphieuNhap { get; set; }
        [Required]
        [StringLength(50)]
        public string MaPhieuNhap { get; set; }
        [Required]
        [StringLength(50)]
        public string MaThongTin { get; set; }
        public int? SoLuong { get; set; }
        public double? DonGiaNhap { get; set; }
        public int? TrangThai { get; set; }

        [ForeignKey(nameof(MaPhieuNhap))]
        [InverseProperty(nameof(PhieuNhap.PhieuNhapChiTiets))]
        public virtual PhieuNhap MaPhieuNhapNavigation { get; set; }
        [ForeignKey(nameof(MaThongTin))]
        [InverseProperty(nameof(ThongTinSanPham.PhieuNhapChiTiets))]
        public virtual ThongTinSanPham MaThongTinNavigation { get; set; }
    }
}
