using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1_DAL_DataAccesLayer.Models
{
    [Table("NhanVien")]
    public partial class NhanVien
    {
        public NhanVien()
        {
            HoaDons = new HashSet<HoaDon>();
            PhieuNhaps = new HashSet<PhieuNhap>();
        }

        [Column("ID")]
        public int Id { get; set; }
        [Key]
        [StringLength(50)]
        public string MaNhanVien { get; set; }
        [StringLength(100)]
        public string TenNhanVien { get; set; }
        [Column("SoCMND")]
        [StringLength(50)]
        public string SoCmnd { get; set; }
        public int? NamSinh { get; set; }
        [StringLength(500)]
        public string DiaChi { get; set; }
        [StringLength(15)]
        public string SoDienThoai { get; set; }
        [StringLength(50)]
        public string MatKhau { get; set; }
        [Required]
        [StringLength(50)]
        public string MaChucVu { get; set; }
        public int? TrangThai { get; set; }

        [ForeignKey(nameof(MaChucVu))]
        [InverseProperty(nameof(ChucVu.NhanViens))]
        public virtual ChucVu MaChucVuNavigation { get; set; }
        [InverseProperty(nameof(HoaDon.MaNhanVienNavigation))]
        public virtual ICollection<HoaDon> HoaDons { get; set; }
        [InverseProperty(nameof(PhieuNhap.MaNhanVienNavigation))]
        public virtual ICollection<PhieuNhap> PhieuNhaps { get; set; }
    }
}
