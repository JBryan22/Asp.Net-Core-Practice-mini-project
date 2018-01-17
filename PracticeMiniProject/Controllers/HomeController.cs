using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PracticeMiniProject.Models;

namespace PracticeMiniProject.Controllers
{
    public class HomeController : Controller
    {
        public IRepository myRepository = SimpleRepository.SharedRepository;

        public IActionResult Index() => View(myRepository.Books);

        [HttpGet]
        public IActionResult AddBook() => View();

        [HttpPost]
        public IActionResult AddBook(Book b)
        {
            myRepository.AddBook(b);
            return RedirectToAction("Index");
        }
    }
}