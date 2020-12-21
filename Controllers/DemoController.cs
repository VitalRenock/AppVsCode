using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AppVsCode.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult Bootstrap()
        {
            ViewBag.Message = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Est cupiditate adipisci nulla ullam accusantium facere iste itaque eaque unde modi a illo error, repellendus officia quaerat minima accusamus vero? Aliquam!";
            return View();
        }

        public IActionResult Razor()
        {
            ViewBag.Messag = "Message du ViewBag";
            
            #region ViewData

            ViewData["Message"] = "Message du ViewData";
            // Ou
            // ViewData.Add("Prénom", "Bill");

            #endregion

            return View();
        }
    }
}