using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL_DataAccesLayer.Entities
{
    [Table("NHANVIEN")]
    public class NHANVIEN
    {
        [Key]
        [Required]
        [StringLength(50)]
        public string MANHANVIEN { get; set; }
        [Required]
        public int? ID { get; set; }
        [Required]
        [StringLength(50)]
        public string TENNHANVIEN { get; set; }
        [Required]
        [StringLength(50)]
        public string SOCMND { get; set; }
        [Required]
        [StringLength(50)]
        public int? NAMSINH { get; set; }
        [StringLength(500)]
        public string DIACHI { get; set; }
        [Required]
        [StringLength(15)]
        public string SODIENTHOAI { get; set; }
        [Required]
        [StringLength(50)]
        public string MATKHAU { get; set; }
        [Required]
        public int? TRANGTHAI { get; set; }

        // [ForeignKey("MACHUCVU")]
        // public CHUCVU CHUCVUS { get; set; }
        public ICollection<PHIEUNHAP> Phieunhaps { get; set; }
        public ICollection<HOADON> Hoadons { get; set; }
        public NHANVIEN()
        {
            Phieunhaps = new HashSet<PHIEUNHAP>();
            Hoadons = new HashSet<HOADON>();
        }
        public CHUCVU Chucvu { get; set; }
        private string aaa;
    }
}
