using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_61131562.Models;

namespace Web_61131562.Controllers
{
    public class MatHangController : Controller
    {
        private ApplicationDbContext _dbConnect = new ApplicationDbContext();
        // GET: MatHang
        public ActionResult Index()
        {
           
            var items = _dbConnect.MatHangs.ToList();
            
            return View(items);
        }
        public ActionResult ChiTietMH(string alias, int id)
        {
            var item = _dbConnect.MatHangs.Find(id);
            if (item != null)
            {
                _dbConnect.MatHangs.Attach(item);
                item.LuotXem = item.LuotXem + 1;
                _dbConnect.Entry(item).Property(x => x.LuotXem).IsModified = true;
                
                _dbConnect.SaveChanges();
            }
            
            return View(item);
        }
            
        public ActionResult LoaiMH(string alias, int id)
        {

            var items = _dbConnect.MatHangs.ToList();
            if (id > 0)
            {
                items = items.Where(x => x.MaLMH == id).ToList();
            }
            var cate = _dbConnect.LoaiMHs.Find(id);
            if (cate != null)
            {
                ViewBag.CateName = cate.TenLMH;
            }
            ViewBag.CateId = id;
            return View(items);
        }

        public ActionResult Partial_ItemByCateId()
        {
            var items = _dbConnect.MatHangs.Where(x => x.IsHome && x.IsActive).Take(12).ToList();
            return PartialView(items); 
        }
        public ActionResult Partial_MatHangSale()
        {
            var items = _dbConnect.MatHangs.Where(x => x.IsMHSale && x.IsActive).Take(12).ToList();
            return PartialView(items);
        }
    }
}