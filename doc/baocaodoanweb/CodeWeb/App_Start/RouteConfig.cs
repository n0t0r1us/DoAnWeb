using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Web_61131562
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
                name: "LienHe",
                url: "lien-he",
                defaults: new { controller = "LienHe", action = "Index", alias = UrlParameter.Optional },
                namespaces: new[] { "Web_61131562.Controllers" }
            );
            routes.MapRoute(
                name: "ThanhToan",
                url: "thanh-toan",
                defaults: new { controller = "GioHang", action = "ThanhToan", alias = UrlParameter.Optional },
                namespaces: new[] { "Web_61131562.Controllers" }
            );
            routes.MapRoute(
                name: "GioHang",
                url: "gio-hang",
                defaults: new { controller = "GioHang", action = "Index", alias = UrlParameter.Optional },
                namespaces: new[] { "Web_61131562.Controllers" }
            );
            routes.MapRoute(
                name: "LoaiMH",
                url: "danh-muc-mat-hang/{alias}-{id}",
                defaults: new { controller = "MatHang", action = "LoaiMH", id = UrlParameter.Optional },
                namespaces: new[] { "Web_61131562.Controllers" }
            );
            routes.MapRoute(
                name: "BaiViet",
                url: "post/{alias}",
                defaults: new { controller = "BaiViet", action = "Index", alias = UrlParameter.Optional },
                namespaces: new[] { "Web_61131562.Controllers" }
            );
            routes.MapRoute(
                name: "ChiTietMatHang",
                url: "chi-tiet/{alias}-p{id}",
                defaults: new { controller = "MatHang", action = "ChiTietMH", alias = UrlParameter.Optional },
                namespaces: new[] { "Web_61131562.Controllers" }
            );
            routes.MapRoute(
                name: "MatHang",
                url: "mat-hang",
                defaults: new { controller = "MatHang", action = "Index", alias = UrlParameter.Optional },
                namespaces: new[] { "Web_61131562.Controllers" }
            );
            routes.MapRoute(
                name: "ChiTietTinTuc",
                url: "{alias}-n{id}",
                defaults: new { controller = "TinTuc", action = "ChiTiet", id = UrlParameter.Optional },
                namespaces: new[] { "Web_61131562.Controllers" }
            );
            routes.MapRoute(
                name: "TinTuc",
                url: "tin-tuc",
                defaults: new { controller = "TinTuc", action = "Index", alias = UrlParameter.Optional },
                namespaces: new[] { "Web_61131562.Controllers" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "Web_61131562.Controllers" }
            );
        }
    }
}
