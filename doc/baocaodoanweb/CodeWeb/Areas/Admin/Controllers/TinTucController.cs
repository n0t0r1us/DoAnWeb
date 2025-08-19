using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_61131562.Models;
using Web_61131562.Models.EF;

namespace Web_61131562.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin, Nhân Viên")]
    public class TinTucController : Controller
    {
        private ApplicationDbContext _dbConnect = new ApplicationDbContext();
        // GET: Admin/TinTuc
        public ActionResult Index(string Searchtext,int? page)
        {
            var pageSize = 5;
            if(page == null)
            {
                page = 1;

            }
            IEnumerable<TinTuc> items = _dbConnect.TinTucs.OrderByDescending(x => x.MaTT);
            if (!string.IsNullOrEmpty(Searchtext))
            {
               items = items.Where(x => x.Alias.Contains(Searchtext) || x.TieuDeTT.Contains(Searchtext));
            }
            var pageIndex = page.HasValue ? Convert.ToInt32(page) : 1;
             items = items.ToPagedList(pageIndex, pageSize);
            ViewBag.PageSize = pageSize;
            ViewBag.Page = page;
            return View(items);
        }
        public ActionResult Them()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Them(TinTuc model)
        {
            if (ModelState.IsValid)
            {
                model.NgayTao = DateTime.Now;
                model.MaDM = 5;
                model.NgaySua = DateTime.Now;
                model.Alias = Web_61131562.Models.Common.Filter.FilterChar(model.TieuDeTT);
                _dbConnect.TinTucs.Add(model);
                _dbConnect.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }

        public ActionResult Sua(int id)
        {
            var item = _dbConnect.TinTucs.Find(id);
            return View(item);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Sua(TinTuc model)
        {
            if (ModelState.IsValid)
            {
                model.NgaySua = DateTime.Now;
                model.Alias = Web_61131562.Models.Common.Filter.FilterChar(model.TieuDeTT);
                _dbConnect.TinTucs.Attach(model);
                _dbConnect.Entry(model).State = System.Data.Entity.EntityState.Modified;
                _dbConnect.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }
        [HttpPost]
        public ActionResult Xoa(int id)
        {
            var item = _dbConnect.TinTucs.Find(id);
            if(item != null)
            {
                _dbConnect.TinTucs.Remove(item);
                _dbConnect.SaveChanges();
                return Json(new { success = true });
            }
            return Json(new { success = false });
        }
        [HttpPost]
        public ActionResult IsActive(int id)
        {
            var item = _dbConnect.TinTucs.Find(id);
            if (item != null)
            {
                item.IsActive = !item.IsActive;
                _dbConnect.Entry(item).State = System.Data.Entity.EntityState.Modified;
                _dbConnect.SaveChanges();
                return Json(new { success = true, isActive = item.IsActive });
            }
            return Json(new { success = false });
        }
        [HttpPost]
        public ActionResult XoaTatCa(string ids)
        {
            if (!string.IsNullOrEmpty(ids))
            {
                var items = ids.Split(',');
                if(items!=null && items.Any())
                {
                    foreach(var item in items)
                    {
                        var obj = _dbConnect.TinTucs.Find(Convert.ToInt32(item));
                        _dbConnect.TinTucs.Remove(obj);
                        _dbConnect.SaveChanges();
                    }
                }
                return Json(new { success = true });

            }
            return Json(new { success = false });
        }
    }

}