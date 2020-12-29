using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AppVsCode.Models;
using AppVsCode.Core;

namespace AppVsCode.Controllers
{
    public class ToolsController : Controller
    {
        public IActionResult Index()
        {
            Post monPost = new Post
            {
                Id = 3,
                Title = MyFirstHelper.MyFirstFunc(),
                Content = "MonContenu",
                PostDate = DateTime.Now
            };

                      
            
            return View(monPost);
        }

        public ActionResult Afficher()
        {
            string maString = "Afficher un string";
            return PartialView(maString);
        }
            }
}