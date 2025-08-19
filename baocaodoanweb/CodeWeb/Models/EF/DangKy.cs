using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Web_61131562.Models.EF
{
    [Table("tb_DangKy")]
    public class DangKy
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int MaDK { get; set; }
        [EmailAddress]
        [Required]
        public string Email { get; set; }
        public DateTime NgayTao { get; set; }
    }
}