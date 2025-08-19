using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_61131562.Models;
using Web_61131562.Models.EF;

namespace Web_61131562.Controllers
{
    public class GioHangController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: GioHang
        public ActionResult Index()
        {
            GioHang gioHang = (GioHang)Session["GioHang"];
            if (gioHang != null && gioHang.Items.Any())
            {
                ViewBag.CheckGioHang = gioHang;
            }

            return View();
        }
        public ActionResult ThanhToan()
        {
            GioHang gioHang = (GioHang)Session["GioHang"];
            if (gioHang != null && gioHang.Items.Any())
            {
                ViewBag.CheckGioHang = gioHang;
            }
            return View();
        }
        public ActionResult ThanhToanThanhCong()
        {
            
            return View();
        }
        public ActionResult Partial_Item_ThanhToan()
        {
            GioHang gioHang = (GioHang)Session["GioHang"];
            if (gioHang != null && gioHang.Items.Any())
            {
                return PartialView(gioHang.Items);
            }
            return PartialView();
        }
        public ActionResult Partial_Item_GioHang()
        {
            GioHang gioHang = (GioHang)Session["GioHang"];
            if (gioHang != null && gioHang.Items.Any())
            {
                return PartialView(gioHang.Items);
            }
            return PartialView();
        }
        public ActionResult ShowCount()
        {
            GioHang gioHang = (GioHang)Session["GioHang"];
            if (gioHang != null)
            {
                return Json(new {  Count = gioHang.Items.Count }, JsonRequestBehavior.AllowGet);
            }
            return Json(new {  Count = 0 }, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Partial_ThanhToan()
        {
            return PartialView();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ThanhToan(OrderViewModel req)
        {
            var code = new { Success = false, Code = -1 };
            if (ModelState.IsValid)
            {
                GioHang gioHang = (GioHang)Session["GioHang"];
                if (gioHang != null)
                {
                    DonGia donGia = new DonGia();
                    donGia.TenKH = req.TenKH;
                    donGia.SDT = req.SDT;
                    donGia.DiaChi = req.DiaChi;
                    donGia.Email = req.Email;
                    gioHang.Items.ForEach(x => donGia.CTDHs.Add(new CTDH { 
                        MaMH=x.MaMH,
                        SoLuong=x.SoLuong,
                        Gia=x.GiaBan
                    }));
                    donGia.TongTien = gioHang.Items.Sum(x => (x.GiaBan * x.SoLuong));
                    donGia.LoaiThanhToan = req.LoaiThanhToan;
                    donGia.NgayTao = DateTime.Now;
                    donGia.NgaySua = DateTime.Now;
                    donGia.NguoiTao = req.SDT;
                    Random rd = new Random();
                    donGia.Code = "DH" + rd.Next(0, 9) + rd.Next(0, 9) + rd.Next(0, 9);

                    //donGia.Email = req.Email;
                    db.DonGias.Add(donGia);
                    db.SaveChanges();
                    //send mail cho khách hàng
                    
                    var strMatHang = "";
                    var thanhTien = decimal.Zero;
                    var tongTien = decimal.Zero;
                    foreach (var mh in gioHang.Items)
                    {
                        strMatHang += "<tr>";
                        strMatHang += "<td>"+mh.TenMatHang+"</td>";
                        strMatHang += "<td>" + mh.SoLuong + "</td>";
                        strMatHang += "<td>" + Web_61131562.Common.Common.FormatNumber(mh.TongGia,0) + "</td>";
                        strMatHang += "</tr>";
                        thanhTien += mh.GiaBan * mh.SoLuong;
                    }
                    tongTien = thanhTien;
                    string contentCustomer = System.IO.File.ReadAllText(Server.MapPath("~/Content/template/send2.html"));
                    contentCustomer = contentCustomer.Replace("{{MaDon}}",donGia.Code);
                    contentCustomer = contentCustomer.Replace("{{MatHang}}", strMatHang);
                    contentCustomer = contentCustomer.Replace("{{NgayDat}}", DateTime.Now.ToString("dd/MM/yyyy"));
                    contentCustomer = contentCustomer.Replace("{{TenKH}}", donGia.TenKH);
                    contentCustomer = contentCustomer.Replace("{{SDT}}", donGia.SDT);
                    contentCustomer = contentCustomer.Replace("{{Email}}", req.Email);
                    contentCustomer = contentCustomer.Replace("{{DiaChiNhanHang}}", donGia.DiaChi);
                    contentCustomer = contentCustomer.Replace("{{ThanhTien}}", Web_61131562.Common.Common.FormatNumber(thanhTien,0));
                    contentCustomer = contentCustomer.Replace("{{TongTien}}", Web_61131562.Common.Common.FormatNumber(tongTien,0));
                    Web_61131562.Common.Common.SendMail("DinhVu61131562","Đơn Hàng #"+donGia.Code,contentCustomer.ToString(),req.Email);

                    string contentAdmin = System.IO.File.ReadAllText(Server.MapPath("~/Content/template/send1.html"));
                    contentAdmin = contentAdmin.Replace("{{MaDon}}", donGia.Code);
                    contentAdmin = contentAdmin.Replace("{{MatHang}}", strMatHang);
                    contentAdmin = contentAdmin.Replace("{{NgayDat}}", DateTime.Now.ToString("dd/MM/yyyy"));
                    contentAdmin = contentAdmin.Replace("{{TenKH}}", donGia.TenKH);
                    contentAdmin = contentAdmin.Replace("{{SDT}}", donGia.SDT);
                    contentAdmin = contentAdmin.Replace("{{Email}}", req.Email);
                    contentAdmin = contentAdmin.Replace("{{DiaChiNhanHang}}", donGia.DiaChi);
                    contentAdmin = contentAdmin.Replace("{{ThanhTien}}", Web_61131562.Common.Common.FormatNumber(thanhTien, 0));
                    contentAdmin = contentAdmin.Replace("{{TongTien}}", Web_61131562.Common.Common.FormatNumber(tongTien, 0));
                    Web_61131562.Common.Common.SendMail("DinhVu61131562", "Đơn Hàng Mới #" + donGia.Code, contentAdmin.ToString(), ConfigurationManager.AppSettings["EmailAdmin"]);
                    gioHang.XoaGioHang();
                    return RedirectToAction("ThanhToanThanhCong");
                }
            }
            return Json(code);
        }
        [HttpPost]
        public ActionResult ThemVaoGioHang(int id, int SoLuong)
        {
            var code = new { Success = false, msg="",code =-1, Count=0};
            var db = new ApplicationDbContext();
            var checkMatHang = db.MatHangs.FirstOrDefault(x => x.MaMH == id);
            if (checkMatHang != null)
            {
                GioHang gioHang = (GioHang)Session["GioHang"];
                if (gioHang == null)
                {
                    gioHang = new GioHang();
                }
                GioHangItem item = new GioHangItem
                {
                    MaMH = checkMatHang.MaMH,
                    TenMatHang = checkMatHang.TenMH,
                    TenDMMH = checkMatHang.LoaiMH.TenLMH,
                    Alias = checkMatHang.Alias,
                    SoLuong = SoLuong
                };
                if (checkMatHang.AnhMH.FirstOrDefault(x => x.MacDinh) != null)
                {
                    item.AnhMatHang = checkMatHang.AnhMH.FirstOrDefault(x => x.MacDinh).Anh;
                }
                item.GiaBan = checkMatHang.GiaBan;
                if (checkMatHang.GiaKM > 0)
                {
                    item.GiaBan = (decimal)checkMatHang.GiaKM;

                }
                item.TongGia = item.SoLuong * item.GiaBan;
                gioHang.ThemVaoGioHang(item, SoLuong);
                Session["GioHang"] = gioHang;
                code = new { Success = true, msg = "Thêm Mặt Hàng Vào Giỏ Hàng Thành Công!", code = 1, Count=gioHang.Items.Count };
            }
            return Json(code);
        }
        [HttpPost]
        public ActionResult CapNhat(int id, int SoLuong)
        {
            GioHang gioHang = (GioHang)Session["GioHang"];
            if (gioHang != null)
            {
                gioHang.CapNhatSoLuong(id, SoLuong);
                return Json(new { Success = true });
            }
            return Json(new { Success = false });
        }

        [HttpPost]
        public ActionResult Xoa(int id)
        {
            var code = new { Success = false, msg = "", code = -1, Count = 0 };
            GioHang gioHang = (GioHang)Session["GioHang"];
            if (gioHang != null)
            {
                var checkMatHang = gioHang.Items.FirstOrDefault(x=>x.MaMH==id);
                if (checkMatHang!=null){
                    gioHang.Xoa(id);
                    code = new { Success = true, msg = "", code = 1, Count = gioHang.Items.Count };
                }
            }
            return Json(code);
        }
        
        [HttpPost]
        public ActionResult XoaHet()
        {
            GioHang gioHang = (GioHang)Session["GioHang"];
            if (gioHang != null)
            {
                gioHang.XoaGioHang();
                return Json(new {Success = true});
            }
            return Json(new { Success = false });
        }
    }
}