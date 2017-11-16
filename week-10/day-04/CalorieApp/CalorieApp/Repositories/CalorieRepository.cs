using CalorieApp.Entities;
using CalorieApp.Models;
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

        public List<Food> CalorieTableToList()
        {
            return CalorieContext.Foods.ToList();
        }

        internal void AddFood(Food food)
        {
            CalorieContext.Foods.Add(food);
            CalorieContext.SaveChanges();
        }

        internal void RemoveFoodByName(string name)
        {
            var foodToRemove = CalorieContext.Foods.Where(x => x.Name == name).FirstOrDefault();
            CalorieContext.Foods.Remove(foodToRemove);
            CalorieContext.SaveChanges();
        }

        internal void RemoveFoodById(int id)
        {
            var foodToRemove = CalorieContext.Foods.Where(x => x.Id == id).FirstOrDefault();
            CalorieContext.Foods.Remove(foodToRemove);
            CalorieContext.SaveChanges();
        }
    }
}
