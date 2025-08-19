using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_61131562.Models;

namespace Web_61131562.Controllers
{
    public class BaiVietController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: BaiViet
        public ActionResult Index(string alias)
        {
            var item = db.GioiThieus.FirstOrDefault(x => x.Alias == alias);
            return View(item);
        }
       

    }
}