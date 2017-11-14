using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoApp.Entities;
using TodoApp.Models;
using TodoApp.Services;

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

        public List<Todo> GetActiveTodos()
        {
            var activeTodos = from todo in GetTodos()
                              where todo.IsDone == false
                              select todo;
            return activeTodos.ToList();
        }

        public List<Todo> GetLateTodos()
        {
            var lateTodos = from todo in GetTodos()
                            where DateTime.Compare(todo.Deadline, DateTime.Now) < 0
                            select todo;
            return lateTodos.ToList();
        }

        public int DaysLeft(Todo todo)
        {
            return (int)(todo.Deadline - DateTime.Now).TotalDays;
        }

        public void Add(Todo newTodo)
        {
            TodoContext.Add(newTodo);
            TodoContext.SaveChanges();
        }

        public void Remove(int Id)
        {
            var removeableTodo = TodoContext.Todos.Where(t => t.Id == Id).FirstOrDefault();
            TodoContext.Todos.Remove(removeableTodo);
            TodoContext.SaveChanges();
        }

        internal Todo FindTodo(int id)
        {
            var todoToFind = TodoContext.Todos.Where(t => t.Id == id).FirstOrDefault();
            return todoToFind;
        }

        public void Edit(Todo updatedTodo)
        {
            TodoContext.Todos.Update(updatedTodo);
            TodoContext.SaveChanges();
        }
    }
}
