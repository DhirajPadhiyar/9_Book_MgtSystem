using _9_Book_MgtSystem.Data;
using _9_Book_MgtSystem.Models;
using Microsoft.AspNetCore.Mvc;

namespace _9_Book_MgtSystem.Controllers
{ 
    public class BooksController : Controller
    {
        private readonly ApplicationDbContext _context;
        public BooksController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult InsertData()
        {
            return View();
        }
        [HttpPost]
        public IActionResult InsertData(Bookk bookk)
        {
            if(!ModelState.IsValid)
            {
                return View(bookk);
            }

            _context.Bookks.Add(bookk);
            _context.SaveChanges();
            return RedirectToAction("DisplayData", bookk);
        }
        public IActionResult DisplayData()
        {
            var books = _context.Bookks.ToList();
            return View(books);
        }
    }
}
