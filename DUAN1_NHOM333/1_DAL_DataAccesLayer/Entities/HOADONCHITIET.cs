using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL_DataAccesLayer.Entities
{
    [Table("HOADONCHITIET")]
    public class HOADONCHITIET
    {
        [Required]
        public int? ID { get; set; }
        [Key]
        [Required]
        [StringLength(50)]
        public string MAHOADONCHITIET { get; set; }
        [Required]
        public double? DONGIA { get; set; }
        [Required]
        public int SOLUONG { get; set; }
        [Required]
        [StringLength(50)]
        public string BARCODE { get; set; }
        [Required]
        public bool? TRANGTHAI { get; set; }
        // [ForeignKey("MAHOADON")]
        // public HOADON MAHOADON { get; set; }
        // [ForeignKey("MATHONGTIN")]
        // public THONGTINHANGHOA MATHONGTIN { get; set; }
        // [ForeignKey("MAHOADON")]
        // [Required]
        // [StringLength(20)]
        // public string MAHOADON { get; set; }
        // public HOADON HOADON { get; set; }
        //
        // public ICollection<THONGTINHANGHOA> THONGTINHANGHOAS { get; set; }
        public ICollection<HOADON> Hoadons { get; set; }
        public ICollection<THONGTINHANGHOA> Thongtinhanghoas { get; set; }
        public HOADONCHITIET()
        {
            Hoadons = new HashSet<HOADON>();
            Thongtinhanghoas = new HashSet<THONGTINHANGHOA>();
        }

    }
}
