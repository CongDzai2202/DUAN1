using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1_DAL_DataAccesLayer.Models
{
    [Table("ChatLieu")]
    public partial class ChatLieu
    {
        public ChatLieu()
        {
            DonViTinhs = new HashSet<DonViTinh>();
        }

        [Column("ID")]
        public int Id { get; set; }
        [Key]
        [StringLength(50)]
        public string MaChatLieu { get; set; }
        [StringLength(50)]
        public string TenChatLieu { get; set; }
        public int? TrangThai { get; set; }

        [InverseProperty(nameof(DonViTinh.MaChatLieuNavigation))]
        public virtual ICollection<DonViTinh> DonViTinhs { get; set; }
    }
}
