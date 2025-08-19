using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web_61131562.Models.EF
{
    [Table("tb_TinTuc")]
    public class TinTuc : CommonAbstract
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int MaTT { get; set; }
        [Required(ErrorMessage ="Bạn không được để trống tiêu đề tin!")]
        [StringLength(150)]
        public string TieuDeTT { get; set; }
        public string TacGia { get; set; }
        public string Alias { get; set; }
        public string MoTa { get; set; }
        [AllowHtml]
        public string ChiTiet { get; set; }
        public string Anh { get; set; }
        public int MaDM { get; set; }
        public string SeoTieuDe { get; set; }
        public string SeoMoTa { get; set; }
        public string SeoTuKhoa { get; set; }
        public bool IsActive { get; set; }
        public virtual DanhMuc DanhMuc { get; set; }
    }
}