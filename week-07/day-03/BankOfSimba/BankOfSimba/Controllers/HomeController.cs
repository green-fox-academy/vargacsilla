using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BankOfSimba.Models;

namespace BankOfSimba.Controllers
{
    public class HomeController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}

        [Route ("simba")]
        public IActionResult GetAccount()
        {
            return View(new BankAccount("Simba", 2000, AnimalType.Lion));
        }
    }
}
