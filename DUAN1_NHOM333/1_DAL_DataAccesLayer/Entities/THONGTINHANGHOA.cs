using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL_DataAccesLayer.Entities
{
    [Table("THONGTINHANGHOA")]
    public class THONGTINHANGHOA
    {
        [Required]
        public int? ID { get; set; }
        [Key]
        [Required]
        [StringLength(50)]
        public string MATHONGTIN { get; set; }
        [Required]
        public double DONGIA { get; set; }
        [Required]
        public int SOLUONG { get; set; }
        [Required]
        public int? TRANGTHAI { get; set; }
        [Required]
        [StringLength(50)]
        public string BARCODE { get; set; }
        public DateTime HANSUDUNG { get; set; }
        [StringLength(100)]
        public string HINHANH { get; set; }
        // [ForeignKey("MAHANGHOA")]
        // public HANGHOA MAHANGHOA { get; set; }
        // [ForeignKey("MALOAIHANG")]
        // public LOAIHANG MALOAIHANG { get; set; }
        // [ForeignKey("MAKICHTHUOC")]
        // public KICHTHUOC MAKICHTHUOC { get; set; }

        public ICollection<HOADONCHITIET> Hoadonchitiets { get; set; }
        public ICollection<CHITIETPHIEUNHAP> Chitietphieunhaps { get; set; }
        public THONGTINHANGHOA()
        {
            Chitietphieunhaps = new HashSet<CHITIETPHIEUNHAP>();
            Hoadonchitiets = new HashSet<HOADONCHITIET>();
        }
        public LOAIHANG Loaihangs { get; set; }
        public HANGHOA Hanghoas { get; set; }
        public DONVITINH Donvitinhs { get; set; }
        public XUATXU Xuatxus { get; set; }

    }
}
