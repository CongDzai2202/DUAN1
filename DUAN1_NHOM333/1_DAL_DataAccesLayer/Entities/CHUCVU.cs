using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL_DataAccesLayer.Entities
{
    [Table("CHUCVU")]
    public class CHUCVU
    {
        [Key]
        [Required]
        [StringLength(50)]
        public string MACHUCVU { get; set; }
        [Required]
        public int? ID { get; set; }
        [Required]
        [StringLength(50)]
        public string TENCHUCVU { get; set; }
        [Required]
        public bool? TRANGTHAI { get; set; }
        
    }
}
