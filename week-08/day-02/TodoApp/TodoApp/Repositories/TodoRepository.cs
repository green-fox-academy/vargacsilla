using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoApp.Entities;
using TodoApp.Models;

namespace TodoApp.Repositories
{
    public class TodoRepository
    {
        TodoContext TodoContext;

        public TodoRepository(TodoContext todoContext)
        {
            TodoContext = todoContext;
        }

        public List<Todo> GetTodos()
        {
            return TodoContext.Todos.ToList();
        }

        public List<Todo> GetActives(bool isActive)
        {
            if (isActive)
            {
                var activeTodos = from todo in GetTodos()
                                  where todo.IsDone == false
                                  select todo;
                return activeTodos.ToList();
            }
            else
            {
                var activeTodos = from todo in GetTodos()
                                  where todo.IsDone == true
                                  select todo;
                return activeTodos.ToList();
            }
        }

        public void Add(Todo newTodo)
        {
            TodoContext.Add(newTodo);
            TodoContext.SaveChanges();
        }
    }
}
