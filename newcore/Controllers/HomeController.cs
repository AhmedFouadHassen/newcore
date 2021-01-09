using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using newcore.Models;

namespace newcore.Controllers
{
    public class HomeController : Controller
    {
        private readonly Istudents istudents;

        public HomeController(Istudents _istudents)
        {
            this.istudents = _istudents;
        }
        public IActionResult Index()
        {
           
            return View( istudents.students.ToList());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
