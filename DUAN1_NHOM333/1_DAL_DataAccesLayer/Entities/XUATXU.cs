using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL_DataAccesLayer.Entities
{
    [Table("XUATXU")]
    public class XUATXU
    {
        [Required]
        public int? ID { get; set; }
        [Key]
        [Required]
        [StringLength(50)]
        public string MAXUATXU { get; set; }
        [StringLength(50)]
        public string TENNUOC { get; set; }
        public ICollection<THONGTINHANGHOA> Thongtinhanghoas { get; set; }
        public XUATXU()
        {

            Thongtinhanghoas = new HashSet<THONGTINHANGHOA>();
        }
    }
}
