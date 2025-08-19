using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Web_61131562.Models.EF
{
    [Table("tb_DanhMuc")]
    public class DanhMuc : CommonAbstract
    {
        public DanhMuc()
        {
            this.TinTucs = new HashSet<TinTuc>();
        }
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int MaDM { get; set; }
        [Required(ErrorMessage ="Tên danh mục không được để trống!")]
        [StringLength(150)]
        public string TenDM { get; set; }
        public string Alias { get; set; }
        //[StringLength(150)]
        //public string TypeCode { get; set; }
        public string LienKet { get; set; }
        public string MoTa { get; set; }
        [StringLength(150)]
        public string SeoTieuDe { get; set; }
        [StringLength(250)]
        public string SeoMoTa { get; set; }
        [StringLength(150)]
        public string SeoTuKhoa { get; set; }
        public bool IsActive { get; set; }
        public int ViTri { get; set; }
        public ICollection<TinTuc> TinTucs { get; set; }
        public ICollection<GioiThieu> GioiThieus { get; set; }
    }
}