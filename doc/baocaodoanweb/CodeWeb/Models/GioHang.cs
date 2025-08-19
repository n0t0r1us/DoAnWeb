using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web_61131562.Models
{
    public class GioHang
    {
        public List<GioHangItem> Items { get; set; }
        public GioHang()
        {
            this.Items = new List<GioHangItem>();
        }
        public void ThemVaoGioHang(GioHangItem item, int SoLuong)
        {
            var checkExist = Items.FirstOrDefault(x => x.MaMH == item.MaMH);
            if (checkExist != null)
            {
                checkExist.SoLuong += SoLuong;
                checkExist.TongGia = checkExist.GiaBan * checkExist.SoLuong;

            }
            else
            {
                Items.Add(item);
            }
        }
        public void Xoa(int id)
        {
            var checkExist = Items.SingleOrDefault(x => x.MaMH == id);
            if (checkExist != null)
            {
                Items.Remove(checkExist);
            }
        }

        public void CapNhatSoLuong(int id, int SoLuong)
        {
            var checkExist = Items.SingleOrDefault(x => x.MaMH == id);
            if (checkExist != null)
            {
                checkExist.SoLuong = SoLuong;
                checkExist.TongGia = checkExist.GiaBan * checkExist.SoLuong;

            }
        }

        public decimal InTongTien()
        {
            return Items.Sum(x => x.TongGia);
        }
        public int InTongSoLuong()
        { 
            return Items.Sum(x => x.SoLuong);
        }
        public void XoaGioHang()
        {
            Items.Clear();
        }
    }
    public class GioHangItem
    {
        public int MaMH { get; set; }
        public string TenMatHang { get; set; }
        public string Alias { get; set; }
        public string TenDMMH { get; set; }
        public string AnhMatHang { get; set; }
        public int SoLuong { get; set; }
        public decimal GiaBan { get; set; }
        public decimal TongGia { get; set; }
    }
}