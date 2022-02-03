using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KitapProje.Models;


namespace KitapProje.Controllers
{
    public class KategorilerController : Controller
    {
        // GET: Kategoriler
        DbKitapEntities1 db = new DbKitapEntities1();

        public ActionResult Index()
        {
            var degerler = db.Kategori.ToList();
            return View(degerler);
        }
    }
}