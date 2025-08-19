using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web_61131562.Models.EF
{
    [Table("tb_MatHang")]
    public class MatHang : CommonAbstract
    {
        public MatHang()
        {
            this.AnhMH = new HashSet<AnhMH>();
            this.CTDHs = new HashSet<CTDH>();
        }
        
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int MaMH { get; set; }
        [Required]
        [StringLength(250)]
        public string TenMH { get; set; }
        [StringLength(250)]
        public string Alias { get; set; }
        [StringLength(50)]
        public string CodeMatHang { get; set; }
        public string MoTa { get; set; }
        [AllowHtml]
        public string ChiTiet { get; set; }
        [StringLength(250)]
        public string Anh { get; set; }
        public decimal GiaGoc { get; set; }
        public decimal GiaBan { get; set; }
        public decimal? GiaKM { get; set; }
        public int SoLuong { get; set; }
        public int LuotXem { get; set; }
        public bool IsHome { get; set; }
        public bool IsMHSale { get; set; }
        public bool IsMHNoiBat { get; set; }
        public bool IsMHBanChay { get; set; }
        public bool IsActive { get; set; }
        public int MaLMH { get; set; }
        [StringLength(250)]
        public string SeoTieuDe { get; set; }
        [StringLength(500)]
        public string SeoMoTa { get; set; }
        [StringLength(250)]
        public string SeoTuKhoa { get; set; }
        public virtual LoaiMH LoaiMH { get; set; }
        public virtual ICollection<AnhMH> AnhMH { get; set; }
        public virtual ICollection<CTDH> CTDHs { get; set; }
    }
}