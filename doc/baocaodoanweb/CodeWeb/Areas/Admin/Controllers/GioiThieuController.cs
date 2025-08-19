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
    public class GioiThieuController : Controller
    {
        private ApplicationDbContext _dbConnect = new ApplicationDbContext();
        // GET: Admin/GioiThieu
        public ActionResult Index()
        {
            var items = _dbConnect.GioiThieus.ToList();
            return View(items);
        }

        public ActionResult Them()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Them(GioiThieu model)
        {
            if (ModelState.IsValid)
            {
                model.NgayTao = DateTime.Now;
                model.MaDM = 5;
                model.NgaySua = DateTime.Now;
                model.Alias = Web_61131562.Models.Common.Filter.FilterChar(model.TieuDeGT);
                _dbConnect.GioiThieus.Add(model);
                _dbConnect.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }

        public ActionResult Sua(int id)
        {
            var item = _dbConnect.GioiThieus.Find(id);
            return View(item);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Sua(GioiThieu model)
        {
            if (ModelState.IsValid)
            {
                model.NgaySua = DateTime.Now;
                model.Alias = Web_61131562.Models.Common.Filter.FilterChar(model.TieuDeGT);
                _dbConnect.GioiThieus.Attach(model);
                _dbConnect.Entry(model).State = System.Data.Entity.EntityState.Modified;
                _dbConnect.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }
        [HttpPost]
        public ActionResult Xoa(int id)
        {
            var item = _dbConnect.GioiThieus.Find(id);
            if (item != null)
            {
                _dbConnect.GioiThieus.Remove(item);
                _dbConnect.SaveChanges();
                return Json(new { success = true });
            }
            return Json(new { success = false });
        }
        [HttpPost]
        public ActionResult IsActive(int id)
        {
            var item = _dbConnect.GioiThieus.Find(id);
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
                if (items != null && items.Any())
                {
                    foreach (var item in items)
                    {
                        var obj = _dbConnect.GioiThieus.Find(Convert.ToInt32(item));
                        _dbConnect.GioiThieus.Remove(obj);
                        _dbConnect.SaveChanges();
                    }
                }
                return Json(new { success = true });

            }
            return Json(new { success = false });
        }
    }
}