using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web_61131562.Models.EF
{
    [Table("tb_GioiThieu")]
    public class GioiThieu : CommonAbstract
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int MaGT { get; set; }
        [Required]
        [StringLength(150)]
        public string TieuDeGT { get; set; }
        [StringLength(150)]
        public string Alias { get; set; }
        public string MoTa { get; set; }
        [AllowHtml]
        public string ChiTiet { get; set; }
        [StringLength(250)]
        public string Anh { get; set; }
        public int MaDM { get; set; }
        [StringLength(250)]
        public string SeoTieuDe { get; set; }
        [StringLength(500)]
        public string SeoMoTa { get; set; }
        [StringLength(250)]
        public string SeoTuKhoa { get; set; }
        public bool IsActive { get; set; }
        public virtual DanhMuc DanhMuc { get; set; }
    }
}