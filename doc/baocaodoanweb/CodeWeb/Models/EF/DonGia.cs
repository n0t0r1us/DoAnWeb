using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Web_61131562.Models.EF
{
    [Table("tb_DonGia")]
    public class DonGia : CommonAbstract
    {
        public DonGia()
        {
            this.CTDHs = new HashSet<CTDH>();
        }
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int MaDG { get; set; }
        [Required]
        public string Code { get; set; }
        [Required(ErrorMessage ="Tên Khánh Hàng Không Được Để Trống!")]
        public string TenKH { get; set; }
        [Required(ErrorMessage = "Số Điện Thoại Không Được Để Trống!")]
        public string SDT { get; set; }
        [Required(ErrorMessage = "Địa Chỉ Không Được Để Trống!")]
        public string DiaChi { get; set; }
        public string Email { get; set; }
        public decimal TongTien { get; set; }
        public int SoLuong { get; set; }
        public int LoaiThanhToan { get; set; }
        public virtual ICollection<CTDH> CTDHs { get; set; }
    }
}