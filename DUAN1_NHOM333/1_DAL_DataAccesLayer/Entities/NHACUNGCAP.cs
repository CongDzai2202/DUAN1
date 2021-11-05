using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL_DataAccesLayer.Entities
{
    [Table("NHACUNGCAP")]
    public class NHACUNGCAP
    {
        [Required]
        public int? ID { get; set; }
        [Key]
        [Required]
        [StringLength(50)]
        public string MANHACUNGCAP { get; set; }
        [Required]
        [StringLength(50)]
        public string TENNHACUNGCAP { get; set; }
        [Required]
        [StringLength(50)]
        public string SODIENTHOAI { get; set; }
    }
}
