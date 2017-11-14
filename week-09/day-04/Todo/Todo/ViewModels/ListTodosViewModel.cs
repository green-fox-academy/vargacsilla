using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoApp.Models;
using TodoApp.Services;

namespace TodoApp.ViewModels
{
    public class ListTodosViewModel
    {
        public TodoService TodoService { get; set; }
        public List<Todo> Todos { get; set; }
    }
}
