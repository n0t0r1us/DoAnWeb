using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Web_61131562.Models.EF
{
    [Table("tb_CTDH")]
    public class CTDH
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int MaCTDH { get; set; }
        public int MaDG { get; set; }
        public int MaMH { get; set; }
        public decimal Gia { get; set; }
        public int SoLuong { get; set; }
        public virtual DonGia DonGia { get; set; }
        public virtual MatHang MatHang { get; set; }
    }
}