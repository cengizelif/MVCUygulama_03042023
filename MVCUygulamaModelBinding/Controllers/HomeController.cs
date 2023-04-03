using MVCUygulamaModelBinding.Models;
using MVCUygulamaModelBinding.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCUygulamaModelBinding.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            Kisi kisi= new Kisi();
            kisi.ID = 1;
            kisi.Ad = "Büşra";
            kisi.Soyad = "Turan";
            kisi.Yas = 27;

            return View(kisi);
        }

        [HttpPost]
        public ActionResult Index(Kisi k)
        {
            return View(k);
        }

        public ActionResult HomePage()
        {          
            Kisi kisi = new Kisi();
            kisi.ID = 1;
            kisi.Ad = "Büşra";
            kisi.Soyad = "Turan";
            kisi.Yas = 27;

            Adres adres = new Adres();
            adres.AdresTanim = "Kadıköy";
            adres.Sehir = "İstanbul";

            IndexViewModel model = new IndexViewModel();
            model.KisiTanim = kisi;
            model.KisiAdres = adres;    

            return View(model);
        }

        [HttpPost]
        public ActionResult HomePage(IndexViewModel model)
        {
            return View(model);
        }
    }
}