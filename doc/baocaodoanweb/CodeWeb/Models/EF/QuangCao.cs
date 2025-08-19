using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Web_61131562.Models.EF
{
    [Table("tb_QuangCao")]
    public class QuangCao : CommonAbstract
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int MaQC { get; set; }
        [Required]
        [StringLength(150)]
        public string TieuDeQC { get; set; }
        [StringLength(500)]
        public string MoTa { get; set; }
        [StringLength(500)]
        public string Anh { get; set; }
        [StringLength(500)]
        public string LienKet { get; set; }
        public int Loai { get; set; }
    }
}