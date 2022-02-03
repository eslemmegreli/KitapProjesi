using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KitapProje.Models;
using PagedList;
using PagedList.Mvc;


namespace KitapProje.Controllers
{
    public class KitapController : Controller
    {
        // GET: Kitap
        DbKitapEntities1 db = new DbKitapEntities1();
        public ActionResult Index(int sayfa = 1) {
            var kitaplar = db.Kitap.ToList().ToPagedList(sayfa, 4);
            return View(kitaplar);
        }

         
        [HttpGet]  //sayfada hiç bişey yapmazsam burası çalışsın
        public ActionResult KitapEkle()
        {
            List<SelectListItem> degerler = (from i in db.Kategori.ToList()
                                             select new SelectListItem
                                             {
                                                 Text = i.KATEGORİAD,
                                                 Value = i.ID.ToString()

                                             }).ToList();
            ViewBag.dgr = degerler; //taşıma işlemi yaptım
            return View();
        }
       [HttpPost] //butona tıklayınca burası
       public ActionResult KitapEkle(Kitap t)
        {
           
            db.Kitap.Add(t);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult KitapSil(int id)
        {
            var kitaps = db.Kitap.Find(id);
            db.Kitap.Remove(kitaps);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult KitapGetir(int id)
        {
            var ktp = db.Kitap.Find(id);
            return View("KitapGetir", ktp);
        }
        public ActionResult KitapGuncelle(Kitap t)
        {
            var kitap0 = db.Kitap.Find(t.KİTAPID);
            kitap0.AD = t.AD;
            kitap0.YAZAR = t.YAZAR;
            kitap0.SAYFA = t.SAYFA;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult KategoriGetir(int id)
        {
            var ktgr = db.Kategori.Find(id);
            return View("KategoriGetir",ktgr);

        }
    }
}
