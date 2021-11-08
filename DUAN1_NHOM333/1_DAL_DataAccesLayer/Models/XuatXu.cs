using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1_DAL_DataAccesLayer.Models
{
    [Table("XuatXu")]
    public partial class XuatXu
    {
        public XuatXu()
        {
            ThongTinSanPhams = new HashSet<ThongTinSanPham>();
        }

        [Column("ID")]
        public int Id { get; set; }
        [Key]
        [StringLength(50)]
        public string MaXuatXu { get; set; }
        [StringLength(50)]
        public string TenNuoc { get; set; }
        public int? TrangThai { get; set; }

        [InverseProperty(nameof(ThongTinSanPham.MaXuatXuNavigation))]
        public virtual ICollection<ThongTinSanPham> ThongTinSanPhams { get; set; }
    }
}
