using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1_DAL_DataAccesLayer.Models
{
    [Table("HoaDon")]
    public partial class HoaDon
    {
        public HoaDon()
        {
            HoaDonChiTiets = new HashSet<HoaDonChiTiet>();
        }

        [Column("ID")]
        public int Id { get; set; }
        [Key]
        [StringLength(50)]
        public string MaHoaDon { get; set; }
        [Required]
        [StringLength(50)]
        public string MaNhanVien { get; set; }
        [Column(TypeName = "date")]
        public DateTime? NgayXuat { get; set; }
        public double? ThanhTien { get; set; }
        public int? TrangThai { get; set; }

        [ForeignKey(nameof(MaNhanVien))]
        [InverseProperty(nameof(NhanVien.HoaDons))]
        public virtual NhanVien MaNhanVienNavigation { get; set; }
        [InverseProperty(nameof(HoaDonChiTiet.MaHoaDonNavigation))]
        public virtual ICollection<HoaDonChiTiet> HoaDonChiTiets { get; set; }
    }
}
