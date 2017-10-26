using Microsoft.AspNetCore.Mvc;
using AnagramApp.Models;

namespace AnagramApp.Controllers
{
    public class HomeController : Controller
    {
        Anagram anagram;

        public HomeController(Anagram anagram)
        {
            this.anagram = anagram;
        }

        [HttpGet]
        [Route ("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route("isAnagram")]
        public IActionResult IsAnagram(string word1, string word2)
        {
            anagram.Word1 = word1;
            anagram.Word2 = word2;

            return RedirectToAction("Result");
        }

        [HttpGet]
        [Route("isAnagram")]
        public IActionResult Result()
        {
            return View(anagram);
        }

    }
}
