using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace dotNetMVCVoorbeeld.Controllers {
    public class HomeController : Controller {

        private string[] groenten = { "Rode kool", "Wortel", "Aardappel", "Bloemkool" };
        public ViewResult Index(string name) {
            ViewBag.Groet = DateTime.Now.Hour < 12 ? "Goeiemorgen" : "Goeimiddag";
            return View();
        }

        public ViewResult Groenten(string zoek) {

            ViewBag.Groenten = groenten;
            if (!string.IsNullOrEmpty(zoek)) {
                ViewBag.Zoekresultaat = $"De gezochte groente is " +
                                        $"{Array.IndexOf(groenten, zoek) + 1}e uit de lijst van groenten";
            }
            return View();
        }
    }
}