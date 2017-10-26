using GreetApp.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GreetApp.Controllers
{
    public class HomeController : Controller
    {
        User user;

        public HomeController(User user)
        {
            this.user = user;
        }

        [HttpGet]
        [Route ("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route ("greet")]
        public IActionResult GiveName(string name)
        {
            user.Name = name;
            return RedirectToAction("Greet");
        }

        [HttpGet]
        [Route ("greet")]
        public IActionResult Greet()
        {
            return View(user);
        }
    }
}
