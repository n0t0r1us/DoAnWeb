using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Web_61131562.Models.EF
{
    [Table("tb_AnhMH")]
    public class AnhMH
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int MaAMH { get; set; }
        public int MaMH { get; set; }
        public string Anh { get; set; }
        public bool MacDinh { get; set; }
        public virtual MatHang MatHang { get; set; }
    }
}