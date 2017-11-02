using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TodoApp.Repositories;
using TodoApp.Models;

namespace TodoApp.Controllers
{
    [Route("/todo")]
    public class TodoController : Controller
    {
        TodoRepository TodoRepository;

        public TodoController(TodoRepository todoRepository)
        {
            TodoRepository = todoRepository;
        }

        [Route("list")]
        public IActionResult List()
        {
            return View(TodoRepository.GetTodos());
        }

        [Route("list/isActive")]
        public IActionResult IsActive(bool isActive)
        {
            return View("List", TodoRepository.GetActives(isActive));
        }

        [HttpGet]
        [Route("add")]
        public IActionResult Add()
        {
            return View("Add");
        }

        [HttpPost]
        [Route("add")]
        public IActionResult Add(Todo todoFromForm)
        {
            TodoRepository.Add(todoFromForm);
            return RedirectToAction("List");
        }

        [HttpGet]
        [Route("{id}/delete")]
        public IActionResult Delete(int id)
        {
           TodoRepository.Remove(id);
           return RedirectToAction("List");
        }

        [HttpGet]
        [Route("{id}/edit")]
        public IActionResult Edit(int id)
        {
            return View("Edit", TodoRepository.GetTodo(id));
        }

        [HttpPost]
        [Route("{id}/edit")]
        public IActionResult Edit(Todo updatedTodo)
        {
            TodoRepository.Edit(updatedTodo);
            return RedirectToAction("List");
        }
    }
}
