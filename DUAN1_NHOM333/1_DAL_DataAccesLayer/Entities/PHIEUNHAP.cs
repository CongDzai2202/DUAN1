﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL_DataAccesLayer.Entities
{
    [Table("PHIEUNHAP")]
    public class PHIEUNHAP
    {
        [Required]
        public int? ID { get; set; }
        [Key]
        [Required]
        [StringLength(50)]
        public string MAPHIEUNHAP { get; set; }
        [Required]
        public DateTime NGAYNHAP { get; set; }
        [Required]
        public bool? TRANGTHAI { get; set; }
        // [ForeignKey("MANHANVIEN")]
        // public NHANVIEN MANHANVIEN { get; set; }
        // [ForeignKey("MANHACUNGCAP")]
        // public NHACUNGCAP MANHACUNGCAP { get; set; }
        public ICollection<NHANVIEN> Nhanviens { get; set; }
        public ICollection<NHACUNGCAP> Nhacungcaps { get; set; }
        public PHIEUNHAP()
        {
            Nhanviens = new HashSet<NHANVIEN>();
            Nhacungcaps = new HashSet<NHACUNGCAP>();
        }
    }
}
