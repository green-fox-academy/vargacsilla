using CalorieApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalorieApp.Repositories
{
    public class CalorieRepository
    {
        CalorieContext CalorieContext;

        public CalorieRepository(CalorieContext calorieContext)
        {
            CalorieContext = calorieContext;
        }
    }
}
