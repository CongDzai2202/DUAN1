using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL_DataAccesLayer.Entities
{
    [Table("CHITIETPHIEUNHAP")]
    public class CHITIETPHIEUNHAP
    {
        [Required]
        public int? ID { get; set; }
        [Key]
        [Required]
        [StringLength(50)]
        public string MACHITIETPHIEUNHAP { get; set; }
        [Required]
        public float SOLUONG { get; set; }
        [Required]
        public double DONGIA { get; set; }
        [Required]
        public int? TRANGTHAI { get; set; }
      
        public ICollection<PHIEUNHAP> Phieunhaps { get; set; }
        public ICollection<THONGTINHANGHOA> Thongtinhanghoas { get; set; }
        public CHITIETPHIEUNHAP()
        {
            Phieunhaps = new HashSet<PHIEUNHAP>();
            Thongtinhanghoas = new HashSet<THONGTINHANGHOA>();
        }
    }
}
