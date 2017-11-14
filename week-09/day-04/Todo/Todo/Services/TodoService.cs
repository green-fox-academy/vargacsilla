using System.Collections.Generic;
using TodoApp.Models;
using TodoApp.Repositories;

namespace TodoApp.Services
{
    public class TodoService
    {
        TodoRepository TodoRepository;

        public TodoService(TodoRepository todoRepository)
        {
            TodoRepository = todoRepository;
        }

        public List<Todo> ListTodos()
        {
            return TodoRepository.GetTodos();
        }

        public List<Todo> ListActiveTodos()
        {
            return TodoRepository.GetActiveTodos();
        }

        public List<Todo> ListLateTodos()
        {
            return TodoRepository.GetLateTodos();
        }

        public int DaysLeft(Todo todo)
        {
            return TodoRepository.DaysLeft(todo);
        }

        public void AddTodo(Todo todo)
        {
            TodoRepository.Add(todo);
        }

        public Todo FindTodo(int todoId)
        {
            return TodoRepository.FindTodo(todoId);
        }

        public void RemoveTodo(int todoId)
        {
            TodoRepository.Remove(todoId);
        }

        public void EditTodo(Todo todo)
        {
            TodoRepository.Edit(todo);
        }
    }
}
