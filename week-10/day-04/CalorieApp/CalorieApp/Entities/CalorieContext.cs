using CalorieApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalorieApp.Entities
{
    public class CalorieContext : DbContext
    {
        public DbSet<Food> Foods { get; set; }

        public CalorieContext(DbContextOptions<CalorieContext> options) : base(options)
        {
        }
    }
}

