using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1_DAL_DataAccesLayer.Models
{
    [Table("NhaCungCap")]
    public partial class NhaCungCap
    {
        public NhaCungCap()
        {
            PhieuNhaps = new HashSet<PhieuNhap>();
        }

        [Column("ID")]
        public int Id { get; set; }
        [Key]
        [StringLength(50)]
        public string MaNhaCungCap { get; set; }
        [StringLength(50)]
        public string TenNhaCungCap { get; set; }
        [StringLength(15)]
        public string SoDienThoai { get; set; }
        [StringLength(50)]
        public string DiaChi { get; set; }
        public int? TrangThai { get; set; }

        [InverseProperty(nameof(PhieuNhap.MaNhaCungCapNavigation))]
        public virtual ICollection<PhieuNhap> PhieuNhaps { get; set; }
    }
}
