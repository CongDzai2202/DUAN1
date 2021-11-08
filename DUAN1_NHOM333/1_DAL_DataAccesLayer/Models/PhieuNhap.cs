using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1_DAL_DataAccesLayer.Models
{
    [Table("PhieuNhap")]
    public partial class PhieuNhap
    {
        public PhieuNhap()
        {
            PhieuNhapChiTiets = new HashSet<PhieuNhapChiTiet>();
        }

        [Column("ID")]
        public int Id { get; set; }
        [Key]
        [StringLength(50)]
        public string MaPhieuNhap { get; set; }
        [Required]
        [StringLength(50)]
        public string MaNhaCungCap { get; set; }
        [Required]
        [StringLength(50)]
        public string MaNhanVien { get; set; }
        [Column(TypeName = "date")]
        public DateTime? NgayNhap { get; set; }
        public int? TrangThai { get; set; }

        [ForeignKey(nameof(MaNhaCungCap))]
        [InverseProperty(nameof(NhaCungCap.PhieuNhaps))]
        public virtual NhaCungCap MaNhaCungCapNavigation { get; set; }
        [ForeignKey(nameof(MaNhanVien))]
        [InverseProperty(nameof(NhanVien.PhieuNhaps))]
        public virtual NhanVien MaNhanVienNavigation { get; set; }
        [InverseProperty(nameof(PhieuNhapChiTiet.MaPhieuNhapNavigation))]
        public virtual ICollection<PhieuNhapChiTiet> PhieuNhapChiTiets { get; set; }
    }
}
