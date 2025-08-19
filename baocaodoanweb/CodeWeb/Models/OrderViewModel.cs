using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Web_61131562.Models
{
    public class OrderViewModel
    {
        [Required(ErrorMessage = "Tên Khánh Hàng Không Được Để Trống!")]
        public string TenKH { get; set; }
        [Required(ErrorMessage = "Số Điện Thoại Không Được Để Trống!")]
        public string SDT { get; set; }
        [Required(ErrorMessage = "Địa Chỉ Không Được Để Trống!")]
        public string DiaChi { get; set; }
        public string Email { get; set; }
        public int LoaiThanhToan { get; set; }
    }
}