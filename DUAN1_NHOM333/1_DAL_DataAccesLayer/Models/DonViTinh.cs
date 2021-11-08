using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1_DAL_DataAccesLayer.Models
{
    [Table("DonViTinh")]
    public partial class DonViTinh
    {
        public DonViTinh()
        {
            ThongTinSanPhams = new HashSet<ThongTinSanPham>();
        }

        [Column("ID")]
        public int Id { get; set; }
        [Key]
        [StringLength(50)]
        public string MaDonViTinh { get; set; }
        [Required]
        [StringLength(50)]
        public string TenDonViTinh { get; set; }
        [Required]
        [StringLength(50)]
        public string MaChatLieu { get; set; }
        public int? TrangThai { get; set; }

        [ForeignKey(nameof(MaChatLieu))]
        [InverseProperty(nameof(ChatLieu.DonViTinhs))]
        public virtual ChatLieu MaChatLieuNavigation { get; set; }
        [InverseProperty(nameof(ThongTinSanPham.MaDonViTinhNavigation))]
        public virtual ICollection<ThongTinSanPham> ThongTinSanPhams { get; set; }
    }
}
