using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KitapProje.Models;

namespace KitapProje.Controllers
{
    public class IletisimController : Controller
    {
        DbKitapEntities1 db = new DbKitapEntities1();
        // GET: Iletisim
        public ActionResult Index()
        {
            return View();
        }
    }
}