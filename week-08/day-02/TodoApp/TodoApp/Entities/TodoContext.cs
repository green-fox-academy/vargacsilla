using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoApp.Models;

namespace TodoApp.Entities
{
    public class TodoContext : DbContext
    {
        List<Todo> list { get; set; }
    }
}
