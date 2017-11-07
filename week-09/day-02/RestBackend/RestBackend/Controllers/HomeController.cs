using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RestBackend.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RestBackend.Controllers
{
    public class HomeController : Controller
    {
        [Route("")]
        public IActionResult Index()
        {
            return File("index.html", "text/html");
        }

        [HttpGet]
        [Route("/doubling")]
        public IActionResult Doubling(int? input)
        {
            if (input == null)
            {
                return Json(new { error = "Please provide an input!" });
            }
            return Json(new { received = input, result = input*2 });
        }

        [HttpGet]
        [Route("/greeter")]
        public IActionResult Greeter(string name, string title)
        {
            if (name == null)
            {
                return Json(new { error = "Please provide a name!" });
            }
            else if (title == null)
            {
                return Json(new { error = "Please provide a title!" });
            }
            return Json(new { Welcome_message = $"Oh, hi there {name}, my dear {title}!"});
        }

        [HttpGet]
        [Route("/appenda")]
        [Route("/appenda/{appendable}")]
        public IActionResult AppendA(string appendable)
        {
            if (String.IsNullOrEmpty(appendable))
            {
                return (IActionResult)NotFound();
            }
            return Json(new { appended = appendable + "a" });
        }

        [HttpPost]
        [Route("/dountil")]
        [Route("/dountil/{what}")]
        public IActionResult DoUntil(string what, [FromBody]Number number)
        {
            if (String.IsNullOrEmpty(what))
            {
                return Json(new { error = "Please provide an operation!" });
            }
            if (number == null || number.Until == null)
            {
                return Json(new { error = "Please provide a number!" });
            }
            if (what == "sum")
            {
                return Json( new { result = number.Sum()});
            }
            if (what == "factor")
            {
                return Json(new { result = number.Factor()});
            }
            else
            {
                return NotFound();
            }
        }
    }
}
