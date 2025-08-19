using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_61131562.Models;
using PagedList;

namespace Web_61131562.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    public class DonHangController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: Admin/DonHang
        public ActionResult Index(int? page)
        {
            var items = db.DonGias.OrderByDescending(x => x.NgayTao).ToList();

            if (page == null)
            {
                page = 1;
            }
            var pageNumber = page ?? 1;
            var pageSize = 10;
            ViewBag.PageSize = pageSize;
            ViewBag.Page = pageNumber;
            return View(items.ToPagedList(pageNumber, pageSize));
        }

        public ActionResult View(int id)
        {
            var item = db.DonGias.Find(id);
            return View(item);
        }
        public ActionResult Partial_MatHang(int id)
        {
            var items = db.CTDHs.Where(x => x.MaDG == id).ToList();
            return PartialView(items);
        }
        [HttpPost]
        public ActionResult CapNhatTT(int id, int trangThai)
        {
            var item = db.DonGias.Find(id);
            if (item != null)
            {
                db.DonGias.Attach(item);
                item.LoaiThanhToan = trangThai;
                db.Entry(item).Property(x => x.LoaiThanhToan).IsModified = true;
                db.SaveChanges();
                return Json(new { message = "Success", Success = true });
            }
            return Json(new { message = "UnSuccess", Success = false });
        }
    }
}