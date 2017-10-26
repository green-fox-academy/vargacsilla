using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Counter.Models;

namespace Counter.Controllers
{
    public class HomeController : Controller
    {
        ClickCounter counter;

        public HomeController(ClickCounter counter)
        {
            this.counter = counter;
        }

        [HttpGet]
        [Route ("index")]
        public IActionResult Index()
        {
            return View(counter);
        }

        [HttpPost]
        [Route("index")]
        public IActionResult Increase()
        {
            counter.Raise();
            return RedirectToAction("Index");
        }
    }
}
