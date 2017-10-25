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

        [Route("allAccounts")]
        public IActionResult GetAllAccounts()
        {
            var allAccounts = new List<BankAccount>();
            allAccounts.Add(new BankAccount("Rafiki", 10, AnimalType.Monkey));
            allAccounts.Add(new BankAccount("Kovu", 15000, AnimalType.Lion, true, GoodOrBad.GoodOne));
            allAccounts.Add(new BankAccount("Timon", 500, AnimalType.Surikata));
            allAccounts.Add(new BankAccount("Pumba", 3200, AnimalType.Pig));
            allAccounts.Add(new BankAccount("Shenzi", 3200, AnimalType.Hyena, false, GoodOrBad.Depends));
            allAccounts.Add(new BankAccount("Zordon", 1500, AnimalType.Lion, true, GoodOrBad.BadGuy));

            return View(allAccounts);
        }
    }
}
