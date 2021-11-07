using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL_DataAccesLayer.Entities
{
    [Table("CHATLIEU")]
    public class CHATLIEU
    {
        [Required]
        public int? ID { get; set; }
        [Key]
        [Required]
        [StringLength(50)]
        public string MACHATLIEU { get; set; }
        [StringLength(50)]
        public string TENCHATLIEU { get; set; }
        public int? TRANGTHAI { get; set; }
        public ICollection<DONVITINH> Donvitinhs { get; set; }
        public CHATLIEU()
        {

            Donvitinhs = new HashSet<DONVITINH>();
        }
    }
}
