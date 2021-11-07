using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL_DataAccesLayer.Entities
{
    [Table("HANGHOA")]
    public class HANGHOA
    {
        [Required]
        public int? ID { get; set; }
        [Key]
        [Required]
        [StringLength(50)]
        public string MAHANGHOA { get; set; }
        [Required]
        [StringLength(50)]
        public string TENHANGHOA { get; set; }
        public int? TRANGTHAI { get; set; }

    }
}
