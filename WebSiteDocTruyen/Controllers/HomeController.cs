using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebSiteDocTruyen.Models;
using PagedList;
using PagedList.Mvc;
namespace WebSiteDocTruyen.Controllers
{
    public class HomeController : Controller
    {
        EbooksEntities db = new EbooksEntities();
        public ActionResult Index(int? page)
        {
            //Tạo ra biến số sp trên trang
            int pageSize = 4;
            //Tạo biến số trang
            int pageNumber=(page ?? 1);
            var lstSach = db.Saches.ToList().ToPagedList(pageNumber,pageSize);
            return View(lstSach);
        }
        

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}