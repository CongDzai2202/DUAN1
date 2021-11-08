using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1_DAL_DataAccesLayer.Models
{
    [Table("ChucVu")]
    public partial class ChucVu
    {
        public ChucVu()
        {
            NhanViens = new HashSet<NhanVien>();
        }

        [Column("ID")]
        public int Id { get; set; }
        [Key]
        [StringLength(50)]
        public string MaChucVu { get; set; }
        [Required]
        [StringLength(50)]
        public string TenChucVu { get; set; }
        public int? TrangThai { get; set; }

        [InverseProperty(nameof(NhanVien.MaChucVuNavigation))]
        public virtual ICollection<NhanVien> NhanViens { get; set; }
    }
}
