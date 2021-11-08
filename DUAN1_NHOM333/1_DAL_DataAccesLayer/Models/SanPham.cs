using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1_DAL_DataAccesLayer.Models
{
    [Table("SanPham")]
    public partial class SanPham
    {
        public SanPham()
        {
            ThongTinSanPhams = new HashSet<ThongTinSanPham>();
        }

        [Column("ID")]
        public int Id { get; set; }
        [Key]
        [StringLength(50)]
        public string MaSanPham { get; set; }
        public int? TrangThai { get; set; }

        [InverseProperty(nameof(ThongTinSanPham.MaSanPhamNavigation))]
        public virtual ICollection<ThongTinSanPham> ThongTinSanPhams { get; set; }
    }
}
