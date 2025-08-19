using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_61131562.Models;
using Web_61131562.Models.EF;

namespace Web_61131562.Areas.Admin.Controllers
{
    public class AnhMHController : Controller
    {
        // GET: Admin/AnhMH
        private ApplicationDbContext _dbConnect = new ApplicationDbContext();
        public ActionResult Index(int id)
        {
            ViewBag.MaMH = id;
            var items = _dbConnect.AnhMHs.Where(x => x.MaMH == id).ToList();
            return View(items);
        }
        [HttpPost]
        public ActionResult ThemAnh(int maMH, string url)
        {
            _dbConnect.AnhMHs.Add(new AnhMH
            {
                MaMH = maMH,
                Anh = url,
                MacDinh = false
            }) ;
            _dbConnect.SaveChanges();
            return Json(new { Success=true});
        }
        [HttpPost]
        public ActionResult Xoa(int id)
        {
            var item = _dbConnect.AnhMHs.Find(id);
            _dbConnect.AnhMHs.Remove(item);
            _dbConnect.SaveChanges();
            return Json(new { success = true});
        }
    }
}