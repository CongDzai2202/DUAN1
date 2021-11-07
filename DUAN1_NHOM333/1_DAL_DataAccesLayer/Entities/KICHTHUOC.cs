using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL_DataAccesLayer.Entities
{
    [Table("KICHTHUOC")]
    public class KICHTHUOC
    {
        [Required]
        public int? ID { get; set; }
        [Key]
        [Required]
        [StringLength(50)]
        public string MAKICHTHUOC { get; set; }
        [Required]
        public float TRONGLUONG { get; set; }
        [Required]
        [StringLength(50)]
        public string DONVITINH { get; set; }
        public int? TRANGTHAI { get; set; }

    }
}
