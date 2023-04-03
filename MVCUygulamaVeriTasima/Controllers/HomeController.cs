using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCUygulamaVeriTasima.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            //ViewData["text1"] = "Elif Cengiz";
            //ViewData["kontrol"] = true;

            ViewBag.text1= "Elif Cengiz";
            ViewBag.kontrol = true;

            //SelectListItem[] dizi=new SelectListItem[10];
            ViewBag.liste = new SelectListItem[]
            {
                new SelectListItem() { Text="Büşra"},
                new SelectListItem() { Text="Esmanur"},
                new SelectListItem() { Text="Atakan"}
            };

            TempData["text2"] = ViewBag.text1;
            TempData["kontrol2"] = ViewBag.kontrol;

            TempData.Keep();
           
            return View();
        }

   
        public ActionResult blog()
        {
            ViewBag.text1 = TempData["text2"];
            ViewBag.kontrol = TempData["kontrol2"];

            TempData["list1"]= new SelectListItem[]
            {
                new SelectListItem() { Text="Büşra", Value="B"},
                new SelectListItem() { Text="Esmanur",Value="E"},
                new SelectListItem() { Text="Atakan",Value="A"}
            };
            
            ViewBag.list1 = TempData["list1"];
            
            TempData.Keep();

            return View();
        }

        [HttpPost]
        public ActionResult blog(string text1,bool kontrol,string list1)
        {
            ViewBag.list1 = TempData["list1"];

            var d1 = Request.Form["text1"];
            var d2 = Request.Form.GetValues("kontrol")[0];
            var d3 = Request.Form["list1"];

            return View();
        }
    }
}