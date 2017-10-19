using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebSiteDocTruyen.Models;

namespace WebSiteDocTruyen.Controllers
{
    public class ChuDeController : Controller
    {
        EbooksEntities db = new EbooksEntities();
        // GET: ChuDe
        public ActionResult ChuDePartial()
        {
            var lstChuDe = db.ChuDes.Take(6).ToList();
            return PartialView(lstChuDe);
        }
        //Hiển thị sách theo ChuDe
        public ActionResult SachTheoChuDe(int MaChuDe = 0)
        {
            //Kiểm tra có sách chủ đề đó hay ko
            ChuDe cd = db.ChuDes.SingleOrDefault(n => n.MaChuDe == MaChuDe);
            if (cd==null)
            {
                Response.StatusCode = 404;
                return null;
            }
            //Truy xuất ds theo chủ đề
            List<Sach> lstSach = db.Saches.Where(n => n.MaChuDe == MaChuDe).ToList();
            if (lstSach.Count==0)
            {
                ViewBag.Sach = "Không có sách chủ đề này!";
            }
            return View(lstSach);
        }
    }
}