using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Pesten.Models;

namespace Pesten.Controllers
{
    public class HomeController : Controller
    {
        Dealer model = Dealer.GetDealer();

        public IActionResult Index()
        {
            return View("Index", model);
        }

        public IActionResult Next()
        {
            model.Next();
            return View("Index", model);
        }

        public IActionResult Reset()
        {
            model.Reset();
            return View("Index", model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
