using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Web_61131562.Models.EF
{
    [Table("tb_LienHe")]
    public class LienHe : CommonAbstract
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int MaLH { get; set; }
        [Required(ErrorMessage = "Tên không được để trống!")]
        [StringLength(150, ErrorMessage = "Không được vượt quá 150 ký tự!")]
        public string Ten { get; set; }
        [StringLength(150, ErrorMessage = "Không được vượt quá 150 ký tự!")]
        public string Email { get; set; }
        public string Website { get; set; }
        [StringLength(4000)]
        public string TinNhan { get; set; }
        public bool DaDoc { get; set; }
    }
}