using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KitapProje.Models;

namespace KitapProje.Controllers
{
    public class YazarlarController : Controller
    {
        // GET: Yazarlar
        public ActionResult Index()
        {
            return View();
        }
    }
}