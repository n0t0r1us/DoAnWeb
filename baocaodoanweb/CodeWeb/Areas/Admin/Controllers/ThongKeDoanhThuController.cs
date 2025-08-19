using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_61131562.Models;

namespace Web_61131562.Areas.Admin.Controllers
{
    public class ThongKeDoanhThuController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: Admin/ThongKeDoanhThu
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult GetThongKeDoanhThu(string fromDate, string toDate)
        {
            var query = from o in db.DonGias
                        join od in db.CTDHs
                        on o.MaDG equals od.MaDG
                        join p in db.MatHangs
                        on od.MaMH equals p.MaMH
                        select new
                        {
                            NgayTao = o.NgayTao,
                            SoLuong = od.SoLuong,
                            GiaBan = od.Gia,
                            GiaGoc = p.GiaGoc
                        }; 
            if (!string.IsNullOrEmpty(fromDate))
            {
                DateTime startDate = DateTime.ParseExact(fromDate, "dd/MM/yyyy", null);
                query = query.Where(x => x.NgayTao >= startDate);
            }
            if (!string.IsNullOrEmpty(toDate))
            {
                DateTime endDate = DateTime.ParseExact(toDate, "dd/MM/yyyy", null);
                query = query.Where(x => x.NgayTao < endDate);
            }

            var kq = query.GroupBy(x => DbFunctions.TruncateTime(x.NgayTao)).Select(x => new
            {
                Date = x.Key.Value,
                TongMua = x.Sum(y => y.SoLuong * y.GiaGoc),
                TongBan = x.Sum(y => y.SoLuong * y.GiaBan),
            }).Select(x => new
            {
                Date = x.Date,
                DoanhThu = x.TongBan,
                LoiNhuan = x.TongBan - x.TongMua
            });
            return Json(new { Data= kq }, JsonRequestBehavior.AllowGet);
        }
    }
}