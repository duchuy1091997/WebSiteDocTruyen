using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebSiteDocTruyen.Models;

namespace WebSiteDocTruyen.Controllers
{
    public class SachController : Controller
    {
        EbooksEntities db = new EbooksEntities();
        // GET: Sach
        public ActionResult XemChiTiet(int MaSach)
        {
            Sach sach = db.Saches.SingleOrDefault(n=> n.MaSach==MaSach);
            if (sach == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            return View(sach);
        }
    }
}