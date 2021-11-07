using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL_DataAccesLayer.Entities
{
    [Table("HOADON")]
    public class HOADON
    {
        [Required]
        public int? ID { get; set; }
        [Key]
        [StringLength(50)]
        [Required]
        public string MAHOADON { get; set; }
        [Required]
        public DateTime NGAYXUAT { get; set; }
        [Required]
        public double? THANHTIEN { get; set; }
        [Required]
        public int? TRANGTHAI { get; set; }
        [ForeignKey("MANHANVIEN")]
        public string MANHANVIEN { get; set; }
        public NHANVIEN NHANVIENS { get; set; }
    }
}
