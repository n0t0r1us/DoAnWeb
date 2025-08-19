using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_61131562.Models;
using Web_61131562.Models.EF;

namespace Web_61131562.Areas.Admin.Controllers
{
    public class LoaiMHController : Controller
    {
        private ApplicationDbContext _dbConnect = new ApplicationDbContext();
        // GET: Admin/LoaiMH
        public ActionResult Index()
        {
            var items = _dbConnect.LoaiMHs;
            return View(items);
        }
        public ActionResult Them()
        {
            
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Them(LoaiMH model)
        {
            if (ModelState.IsValid)
            {
                model.NgayTao = DateTime.Now;
                model.NgaySua = DateTime.Now;
                model.Alias = Web_61131562.Models.Common.Filter.FilterChar(model.TenLMH);
                _dbConnect.LoaiMHs.Add(model);
                _dbConnect.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}