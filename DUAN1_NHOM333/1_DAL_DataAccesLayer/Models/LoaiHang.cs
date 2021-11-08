using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1_DAL_DataAccesLayer.Models
{
    [Table("LoaiHang")]
    public partial class LoaiHang
    {
        public LoaiHang()
        {
            ThongTinSanPhams = new HashSet<ThongTinSanPham>();
        }

        [Column("ID")]
        public int Id { get; set; }
        [Key]
        [StringLength(50)]
        public string MaLoaiHang { get; set; }
        [StringLength(50)]
        public string TenLoaiHang { get; set; }
        public int? TrangThai { get; set; }

        [InverseProperty(nameof(ThongTinSanPham.MaLoaiHangNavigation))]
        public virtual ICollection<ThongTinSanPham> ThongTinSanPhams { get; set; }
    }
}
