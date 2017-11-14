using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TodoApp.Repositories;
using TodoApp.ViewModels;
using TodoApp.Services;
using TodoApp.Models;

namespace TodoApp.Controllers
{
    [Route("")]
    public class TodoController : Controller
    {
        TodoService TodoService;

        public TodoController(TodoService todoService)
        {
            TodoService = todoService;
        }

        [HttpGet]
        [Route("")]
        public IActionResult ListTodos()
        {
            var allTodos = new ListTodosViewModel
            {
                TodoService = TodoService,
                Todos = TodoService.ListTodos()
        };
            return View("list", allTodos);
        }

        [HttpGet]
        [Route("late")]
        public IActionResult GetLateToDos()
        {
            var lateTodosViewModel = new ListTodosViewModel
            {
                TodoService = TodoService,
                Todos = TodoService.ListLateTodos()
            } ;

            return View("list", lateTodosViewModel);
        }

        [HttpGet]
        [Route("active")]
        public IActionResult GetActives()
        {
            var activeTodosViewModel = new ListTodosViewModel
            {
                TodoService = TodoService,
                Todos = TodoService.ListActiveTodos()
            };

            return View("list", activeTodosViewModel);
        }

        [HttpGet]
        [Route("add")]
        public IActionResult Add()
        {
            return View("add");
        }

        [HttpPost]
        [Route("add")]
        public IActionResult Add(Todo todoFromForm)
        {
            TodoService.AddTodo(todoFromForm);
            return RedirectToAction("listTodos");
        }

        [HttpGet]
        [Route("{id}/delete")]
        public IActionResult Delete(int id)
        {
            TodoService.RemoveTodo(id);
            return RedirectToAction("listTodos");
        }

        [HttpGet]
        [Route("{id}/edit")]
        public IActionResult Edit(int id)
        {
            return View("edit", TodoService.FindTodo(id));
        }

        [HttpPost]
        [Route("{id}/edit")]
        public IActionResult Edit(Todo updatedTodo)
        {
            TodoService.EditTodo(updatedTodo);
            return RedirectToAction("listTodos");
        }
    }
}
