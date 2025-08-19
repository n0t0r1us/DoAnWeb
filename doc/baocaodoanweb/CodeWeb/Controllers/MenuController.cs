using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_61131562.Models;

namespace Web_61131562.Controllers
{
    public class MenuController : Controller
    {
        private ApplicationDbContext _dbConnect = new ApplicationDbContext();
        // GET: Menu
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult MenuTop()
        {
            var items = _dbConnect.DanhMucs.OrderBy(x => x.ViTri).ToList();
            return PartialView("_MenuTop", items);
        }

        public ActionResult MenuLoaiMH()
        {
            var items = _dbConnect.LoaiMHs.ToList();
            return PartialView("_MenuLoaiMH",items);
        }
        public ActionResult MenuTrai(int? id)
        {
            if (id != null)
            {
                ViewBag.CateId = id;
            }
            var items = _dbConnect.LoaiMHs.ToList();
            return PartialView("_MenuTrai", items);
        }
        public ActionResult MenuArrivals()
        {
            var items = _dbConnect.LoaiMHs.ToList();
            return PartialView("_MenuArrivals", items);
        }
    }
}