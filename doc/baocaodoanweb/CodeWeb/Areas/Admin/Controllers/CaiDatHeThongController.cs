using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_61131562.Models;
using Web_61131562.Models.EF;

namespace Web_61131562.Areas.Admin.Controllers
{
    
    public class CaiDatHeThongController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: Admin/CaiDatHeThong
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Partial_CaiDat()
        {
            return PartialView();
        }
        [HttpPost]
        public ActionResult AddSetting(CaiDatHeThongViewModel req)
        {
            CaiDatHeThong set = null;
            var checkTitle = db.CaiDatHeThongs.FirstOrDefault(x => x.CaiDatKhoa.Contains("SettingTitle"));
            if (checkTitle == null)
            {
                set = new CaiDatHeThong();
                set.CaiDatKhoa = "SettingTitle";
                set.CaiDatGiaTri = req.SettingTitle;
                db.CaiDatHeThongs.Add(set);
            }
            else
            {
                checkTitle.CaiDatGiaTri = req.SettingTitle;
                db.Entry(checkTitle).State = System.Data.Entity.EntityState.Modified;
            }
            //logo
            var checkLogo = db.CaiDatHeThongs.FirstOrDefault(x => x.CaiDatKhoa.Contains("SettingLogo"));
            if (checkLogo == null)
            {
                 set = new CaiDatHeThong();
                set.CaiDatKhoa = "SettingLogo";
                set.CaiDatGiaTri = req.SettingLogo;
                db.CaiDatHeThongs.Add(set);
            }
            else
            {
                checkLogo.CaiDatGiaTri = req.SettingLogo;
                db.Entry(checkLogo).State = System.Data.Entity.EntityState.Modified;
            }
            //Email
            var email = db.CaiDatHeThongs.FirstOrDefault(x => x.CaiDatKhoa.Contains("SettingEmail"));
            if (email == null)
            {
                set = new CaiDatHeThong();
                set.CaiDatKhoa = "SettingEmail";
                set.CaiDatGiaTri = req.SettingEmail;
                db.CaiDatHeThongs.Add(set);
            }
            else
            {
                email.CaiDatGiaTri = req.SettingEmail;
                db.Entry(email).State = System.Data.Entity.EntityState.Modified;
            }
            //Hotline
            var Hotline = db.CaiDatHeThongs.FirstOrDefault(x => x.CaiDatKhoa.Contains("SettingHotline"));
            if (Hotline == null)
            {
                set = new CaiDatHeThong();
                set.CaiDatKhoa = "SettingHotline";
                set.CaiDatGiaTri = req.SettingHotline;
                db.CaiDatHeThongs.Add(set);
            }
            else
            {
                Hotline.CaiDatGiaTri = req.SettingHotline;
                db.Entry(Hotline).State = System.Data.Entity.EntityState.Modified;
            }
            //TitleSeo
            var TitleSeo = db.CaiDatHeThongs.FirstOrDefault(x => x.CaiDatKhoa.Contains("SettingTitleSeo"));
            if (TitleSeo == null)
            {
                set = new CaiDatHeThong();
                set.CaiDatKhoa = "SettingTitleSeo";
                set.CaiDatGiaTri = req.SettingTitleSeo;
                db.CaiDatHeThongs.Add(set);
            }
            else
            {
                TitleSeo.CaiDatGiaTri = req.SettingTitleSeo;
                db.Entry(TitleSeo).State = System.Data.Entity.EntityState.Modified;
            }
            //DessSeo
            var DessSeo = db.CaiDatHeThongs.FirstOrDefault(x => x.CaiDatKhoa.Contains("SettingDesSeo"));
            if (DessSeo == null)
            {
                set = new CaiDatHeThong();
                set.CaiDatKhoa = "SettingDesSeo";
                set.CaiDatGiaTri = req.SettingDesSeo;
                db.CaiDatHeThongs.Add(set);
            }
            else
            {
                DessSeo.CaiDatGiaTri = req.SettingDesSeo;
                db.Entry(DessSeo).State = System.Data.Entity.EntityState.Modified;
            }
            //KeySeo
            var KeySeo = db.CaiDatHeThongs.FirstOrDefault(x => x.CaiDatKhoa.Contains("SettingKeySeo"));
            if (KeySeo == null)
            {
                set = new CaiDatHeThong();
                set.CaiDatKhoa = "SettingKeySeo";
                set.CaiDatGiaTri = req.SettingKeySeo;
                db.CaiDatHeThongs.Add(set);
            }
            else
            {
                KeySeo.CaiDatGiaTri = req.SettingKeySeo;
                db.Entry(KeySeo).State = System.Data.Entity.EntityState.Modified;
            }
            db.SaveChanges();

            return View("Partial_CaiDat");
        }
    }
}