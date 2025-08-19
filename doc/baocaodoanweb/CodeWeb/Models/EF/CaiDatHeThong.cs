using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Web_61131562.Models.EF
{
    [Table("tb_CaiDatHeThong")]
    public class CaiDatHeThong
    {
        [Key]
        [StringLength(50)]
        public string CaiDatKhoa { get; set; }
        [StringLength(4000)]
        public string CaiDatGiaTri { get; set; }
        [StringLength(4000)]
        public string CaiDatMoTa { get; set; }
    }
}