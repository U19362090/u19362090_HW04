using u19362090_HW04.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace u19362090_HW04.Controllers
{
    public class HomeController : Controller
    {
        // Repository 
       
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Home()
        {
           
            return View(List.Recycles());
        }

        public ActionResult RecyclePlastic()
        {
            
            return View();
        }
        public ActionResult RecycleMetal()
        {

            return View();
        }

        [HttpPost]
        public ActionResult RecyclePlastic(string fullName, int weight, int bags, string plasticType, string color, int plasticRating)
        {
            Random random = new Random();
            int id = random.Next(1, 50000000);
            Plastic plastic = new Plastic(id, fullName, weight, bags, plasticType, color, plasticRating);
            List.Add(plastic);
            
            return View();
        }

        [HttpPost]
        public ActionResult RecycleMetal(string fullName, int weight, int bags, double length, string metalType)
        {
            int id = 0;
            Metal metal = new Metal(id, fullName, weight, bags, metalType, length);
            List.Add(metal);
            id++;
            return View();
        }

        public ActionResult Delete(int id)
        {
            List.Delete(id);
           return RedirectToAction("Home");
        }

        public ActionResult EditPlastic(int id)
        {

            Plastic plastic = (Plastic)List.recycles.FirstOrDefault(x => x.RecycleID == id);
            return View(plastic);
        }

        public ActionResult EditMetal(int id)
        {

            Metal metal = (Metal)List.recycles.FirstOrDefault(x => x.RecycleID == id);
            return View(metal);
        }

        [HttpPost]
        public ActionResult EditMetal(Metal metal)
        {
            List.Edit(metal);

            return RedirectToAction("Home");
        }

        [HttpPost]
        public ActionResult EditPlastic(Plastic plastic)
        {
            List.Edit(plastic);

            return RedirectToAction("Home");
        }

        public ActionResult ViewAllRecycles()
        {
            ViewBag.Message = "Your contact page.";

            return RedirectToAction("Home");
        }
    }
}