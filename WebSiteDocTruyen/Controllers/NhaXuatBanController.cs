using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebSiteDocTruyen.Models;

namespace WebSiteDocTruyen.Controllers
{
    public class NhaXuatBanController : Controller
    {
        EbooksEntities db = new EbooksEntities();
        // GET: NhaXuatBan
        public ActionResult NhaXuatBanPartial()
        {
            var nhaXuatBan = db.NhaXuatBans.ToList();
            return PartialView(nhaXuatBan);
        }
        //Hiển thị sách theo NXB
        public ActionResult SachTheoNXB(int MaNXB = 0)
        {
            //Kiểm tra có sách chủ đề đó hay ko
            NhaXuatBan nxb = db.NhaXuatBans.SingleOrDefault(n => n.MaNXB == MaNXB);
            if (nxb == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            //Truy xuất ds theo chủ đề
            List<Sach> lstSach = db.Saches.Where(n => n.MaNXB == MaNXB).ToList();
            if (lstSach.Count == 0)
            {
                ViewBag.Sach = "Không có sách chủ đề này!";
            }
            return View(lstSach);
        }
    }
}