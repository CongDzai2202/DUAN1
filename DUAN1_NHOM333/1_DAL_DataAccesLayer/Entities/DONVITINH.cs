using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL_DataAccesLayer.Entities
{
    [Table("DONVITINH")]
    public class DONVITINH
    {
        [Required]
        public int? ID { get; set; }
        [Key]
        [Required]
        [StringLength(50)]
        public string MADONVITINH { get; set; }
        [Required]
        [StringLength(50)]
        public string TENDONVITINH { get; set; }
        public int? TRANGTHAI { get; set; }
        public ICollection<THONGTINHANGHOA> Thongtinhanghoas { get; set; }
        public DONVITINH()
        {

            Thongtinhanghoas = new HashSet<THONGTINHANGHOA>();
        }
        public CHATLIEU Chatlieus { get; set; }

    }
}
