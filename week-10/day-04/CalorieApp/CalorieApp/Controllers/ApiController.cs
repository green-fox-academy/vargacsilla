using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CalorieApp.Repositories;
using CalorieApp.Models;

namespace CalorieApp.Controllers
{
    [Route("api")]
    public class ApiController : Controller
    {
        CalorieRepository CalorieRepository;

        public ApiController(CalorieRepository calorieRepository)
        {
            CalorieRepository = calorieRepository;
        }

        [HttpGet]
        [Route("drax")]
        public IActionResult CalorieTable()
        {
            return Json(CalorieRepository.CalorieTableToList());
        }

        [HttpPost]
        [Route("add")]
        public IActionResult AddFood([FromBody]Food food)
        {
            if (food != null)
            {
                CalorieRepository.AddFood(food);
                return Json(new { response = "thx" });
            }
            else
            {
                return Json(new { respose = "error" });
            }
        }

        [HttpGet]
        [Route("remove")]
        [Route("remove/{id}")]
        public IActionResult RemoveFoodById(int id)
        {
            CalorieRepository.RemoveFoodById(id);
            return Ok();
        }
    }
}
