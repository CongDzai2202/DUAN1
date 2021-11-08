using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1_DAL_DataAccesLayer.Models
{
    [Table("HoaDonChiTiet")]
    public partial class HoaDonChiTiet
    {
        [Column("ID")]
        public int Id { get; set; }
        [Key]
        [StringLength(50)]
        public string MaHoaDonChiTiet { get; set; }
        [Required]
        [StringLength(50)]
        public string MaHoaDon { get; set; }
        [StringLength(50)]
        public string MaThongTin { get; set; }
        [StringLength(50)]
        public string TenSanPham { get; set; }
        public double? DonGia { get; set; }
        public int? SoLuong { get; set; }
        [Required]
        [StringLength(50)]
        public string BarCode { get; set; }
        [StringLength(100)]
        public string GhiChu { get; set; }
        public int? TrangThai { get; set; }

        [ForeignKey(nameof(MaHoaDon))]
        [InverseProperty(nameof(HoaDon.HoaDonChiTiets))]
        public virtual HoaDon MaHoaDonNavigation { get; set; }
        [ForeignKey(nameof(MaThongTin))]
        [InverseProperty(nameof(ThongTinSanPham.HoaDonChiTiets))]
        public virtual ThongTinSanPham MaThongTinNavigation { get; set; }
    }
}
