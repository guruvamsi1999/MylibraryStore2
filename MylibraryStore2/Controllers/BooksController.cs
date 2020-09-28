using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MylibraryStore2.Models;
using MylibraryStore2.Repository;

namespace MylibraryStore2.Controllers
{
    public class BooksController : Controller
    {
        private IBookRepository _bookrepos = null;

        public BooksController(IBookRepository bookrepository)
        {
            _bookrepos = bookrepository;
        }
        public IActionResult Index()
        {
            var books = _bookrepos.GetBooks();
            return View(books);
        }
        public IActionResult Details(int id)
        {
            var book = _bookrepos.GetBookById(id);
            return View(book);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Book book)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            _bookrepos.Create(book);
            return RedirectToAction("Index", "Books");
        }

       
        [HttpPost]
        public IActionResult Delete(int? id)
        {
            _bookrepos.Delete(id);
            return RedirectToAction("Index", "Books");
        }


        [HttpGet]
        public IActionResult Update(int id)
        {
            var book = _bookrepos.GetBookById(id);
            return View(book);
        }

        [HttpPost]
        public IActionResult Update(int? id, Book book)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            _bookrepos.Update(id, book);
            return RedirectToAction("Index", "Books");
        }

    }
}
