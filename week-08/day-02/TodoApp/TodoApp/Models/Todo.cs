using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoApp.Models
{
    public class Todo
    {
        int Id { get; set; }
        string Title { get; set; }
        bool IsUrgent { get; set; } = false;
        bool IsDone { get; set; } = false;
    }
}
