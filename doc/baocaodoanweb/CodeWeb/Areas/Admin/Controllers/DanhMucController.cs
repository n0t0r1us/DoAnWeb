using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_61131562.Models;
using Web_61131562.Models.EF;

namespace Web_61131562.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    public class DanhMucController : Controller
    {
        private ApplicationDbContext _dbConnect = new ApplicationDbContext();
        // GET: Admin/DanhMuc
        public ActionResult Index()
        {
            var items = _dbConnect.DanhMucs;
            return View(items);
        }
        public ActionResult ThemMoi()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ThemMoi(DanhMuc model)
        {
            if (ModelState.IsValid)
            {
                model.NgayTao = DateTime.Now;
                model.NgaySua = DateTime.Now;
                model.Alias = Web_61131562.Models.Common.Filter.FilterChar(model.TenDM);
                _dbConnect.DanhMucs.Add(model);
                _dbConnect.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }
        public ActionResult Sua(int id)
        {
            var item = _dbConnect.DanhMucs.Find(id);
            return View(item);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Sua(DanhMuc model)
        {
            if (ModelState.IsValid)
            {
                _dbConnect.DanhMucs.Attach(model);
                model.NgaySua = DateTime.Now;
                model.Alias = Web_61131562.Models.Common.Filter.FilterChar(model.TenDM);
                _dbConnect.Entry(model).Property(x => x.TenDM).IsModified = true;
                _dbConnect.Entry(model).Property(x => x.MoTa).IsModified = true;
                _dbConnect.Entry(model).Property(x => x.LienKet).IsModified = true;
                _dbConnect.Entry(model).Property(x => x.Alias).IsModified = true;
                _dbConnect.Entry(model).Property(x => x.SeoMoTa).IsModified = true;
                _dbConnect.Entry(model).Property(x => x.SeoTuKhoa).IsModified = true;
                _dbConnect.Entry(model).Property(x => x.SeoTieuDe).IsModified = true;
                _dbConnect.Entry(model).Property(x => x.ViTri).IsModified = true;
                _dbConnect.Entry(model).Property(x => x.NgaySua).IsModified = true;
                _dbConnect.Entry(model).Property(x => x.NguoiSua).IsModified = true;
                _dbConnect.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }
        [HttpPost]
        public ActionResult Xoa(int id)
        {
            var item = _dbConnect.DanhMucs.Find(id);
            if(item != null)
            {
                //var XoaItem = _dbConnect.DanhMucs.Attach(item);
                _dbConnect.DanhMucs.Remove(item);
                _dbConnect.SaveChanges();
                return Json(new { success = true });
            }
            return Json(new { success = false });
        }
    }
}