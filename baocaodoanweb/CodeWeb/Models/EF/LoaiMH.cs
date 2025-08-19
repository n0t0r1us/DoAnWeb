using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Web_61131562.Models.EF
{
    [Table("tb_LoaiMH")]
    public class LoaiMH : CommonAbstract
    {
        public LoaiMH()
        {
            this.MatHangs = new HashSet<MatHang>();
        }
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int MaLMH { get; set; }
        [Required]
        [StringLength(150)]
        public string TenLMH { get; set; }
        [Required]
        [StringLength(150)]
        public string Alias { get; set; }
        public string MoTa { get; set; }
        [StringLength(250)]
        public string Icon { get; set; }
        [StringLength(250)]
        public string SeoTieuDe { get; set; }
        [StringLength(500)]
        public string SeoMoTa { get; set; }
        [StringLength(250)]
        public string SeoTuKhoa { get; set; }
        public ICollection<MatHang> MatHangs { get; set; }
    }
}