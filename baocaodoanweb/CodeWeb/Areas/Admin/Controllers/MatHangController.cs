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
    [Authorize(Roles = "Admin,Nhân Viên")]
    public class MatHangController : Controller
    {
        private ApplicationDbContext _dbConnect = new ApplicationDbContext();
        // GET: Admin/MatHang
        public ActionResult Index(int? page)
        {
            IEnumerable<MatHang> items = _dbConnect.MatHangs.OrderByDescending(x => x.MaMH);
            var pageSize = 10;
            if (page == null)
            {
                page = 1;

            }
            var pageIndex = page.HasValue ? Convert.ToInt32(page) : 1;
            items = items.ToPagedList(pageIndex, pageSize);
            ViewBag.PageSize = pageSize;
            ViewBag.Page = page;
            return View(items);
        }
        public ActionResult Them()
        {
            ViewBag.LoaiMH = new SelectList(_dbConnect.LoaiMHs.ToList(), "MaLMH", "TenLMH");
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Them(MatHang model,List<string> Anhs, List<int> rDefault)
        {
            if (ModelState.IsValid)
            {
                if(Anhs != null && Anhs.Count > 0)
                {
                    for(int i=0; i<Anhs.Count; i++)
                    {
                        if (i + 1 == rDefault[0])
                        {
                            model.Anh = Anhs[i];
                            model.AnhMH.Add(new AnhMH
                            {
                                MaMH = model.MaMH,
                                Anh = Anhs[i],
                                MacDinh = true
                            });
                        }
                        else
                        {
                            model.AnhMH.Add(new AnhMH
                            {
                                MaMH = model.MaMH,
                                Anh = Anhs[i],
                                MacDinh = false
                            });
                        }
                    }
                }
                model.NgayTao = DateTime.Now;
                model.NgaySua = DateTime.Now;
                if (string.IsNullOrEmpty(model.SeoTieuDe))
                {
                    model.SeoTieuDe = model.TenMH;
                }
                    if (string.IsNullOrEmpty(model.Alias))
                    model.Alias = Web_61131562.Models.Common.Filter.FilterChar(model.TenMH);
                _dbConnect.MatHangs.Add(model);
                _dbConnect.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.LoaiMH = new SelectList(_dbConnect.LoaiMHs.ToList(), "MaLMH", "TenLMH");
            return View(model);
        }
        public ActionResult Sua(int id)
        {
            ViewBag.LoaiMH = new SelectList(_dbConnect.LoaiMHs.ToList(), "MaLMH", "TenLMH");
            var item = _dbConnect.MatHangs.Find(id);
            return View(item);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Sua(MatHang model)
        {
            if (ModelState.IsValid)
            {
                model.NgaySua = DateTime.Now;
                model.Alias = Web_61131562.Models.Common.Filter.FilterChar(model.TenMH);
                _dbConnect.MatHangs.Attach(model);
                _dbConnect.Entry(model).State = System.Data.Entity.EntityState.Modified;
                _dbConnect.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }

        [HttpPost]
        public ActionResult Xoa(int id)
        {
            var item = _dbConnect.MatHangs.Find(id);
            if (item != null)
            {
                _dbConnect.MatHangs.Remove(item);
                _dbConnect.SaveChanges();
                return Json(new { success = true });
            }
            return Json(new { success = false });
        }

        [HttpPost]
        public ActionResult IsActive(int id)
        {
            var item = _dbConnect.MatHangs.Find(id);
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
        public ActionResult IsHome(int id)
        {
            var item = _dbConnect.MatHangs.Find(id);
            if (item != null)
            {
                item.IsHome = !item.IsHome;
                _dbConnect.Entry(item).State = System.Data.Entity.EntityState.Modified;
                _dbConnect.SaveChanges();
                return Json(new { success = true, isHome = item.IsHome });
            }
            return Json(new { success = false });
        }
        [HttpPost]
        public ActionResult IsMHSale(int id)
        {
            var item = _dbConnect.MatHangs.Find(id);
            if (item != null)
            {
                item.IsMHSale = !item.IsMHSale;
                _dbConnect.Entry(item).State = System.Data.Entity.EntityState.Modified;
                _dbConnect.SaveChanges();
                return Json(new { success = true, isMHSale = item.IsMHSale });
            }
            return Json(new { success = false });
        }
    }
}