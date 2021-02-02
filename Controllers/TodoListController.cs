using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Capstone.Models.DomainModels;
using Capstone.Models.TodoList;
using Microsoft.AspNetCore.Mvc;

namespace Capstone.Controllers
{
    public class TodoListController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult FormResult(TodoListViewModel model) 
        {

            return View();
        }
    }
}
