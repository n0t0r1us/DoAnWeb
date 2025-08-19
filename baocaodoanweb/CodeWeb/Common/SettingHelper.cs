using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Web_61131562.Models;

namespace Web_61131562.Common
{
    public class SettingHelper
    {
        public static string GetValue(string key)
        {
            using (var db = new ApplicationDbContext())
            {
                var item = db.CaiDatHeThongs.SingleOrDefault(x => x.CaiDatKhoa == key);
                if (item != null)
                {
                    return item.CaiDatGiaTri;
                }
                return "";
            }
        }
    }
}