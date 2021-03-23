using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjection1.Controllers
{
    public class BooksController : Controller
    {
        public IActionResult Create()
        {
            return View();
        }
    }
}