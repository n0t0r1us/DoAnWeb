using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_61131562.Models;
using Web_61131562.Models.EF;

namespace Web_61131562.Controllers
{
    public class TinTucController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: TinTuc
        public ActionResult Index(int? page)
        {
            var pageSize = 5;
            if (page == null)
            {
                page = 1;
            }
            IEnumerable<TinTuc> items = db.TinTucs.OrderByDescending(x => x.NgayTao);
            var pageIndex = page.HasValue ? Convert.ToInt32(page) : 1;
            items = items.ToPagedList(pageIndex, pageSize);
            ViewBag.PageSize = pageSize;
            ViewBag.Page = page;
            return View(items);
        }
        public ActionResult ChiTiet(int id)
        {
            var item = db.TinTucs.Find(id);
            return View(item);
        }
        public ActionResult Partial_TinTuc_TrangChu()
        {
            var items = db.TinTucs.Take(3).ToList();
            return PartialView(items);
        }
    }
}