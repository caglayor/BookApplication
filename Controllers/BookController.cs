using BookApplication.Data;
using Microsoft.AspNetCore.Mvc;

namespace BookApplication.Controllers
{
    public class BookController : Controller
    {
        public IActionResult Create()
        {
            return View();
        }

       
        public IActionResult Create(Book book)
        {
            if (ModelState.IsValid)
            {
               
                return RedirectToAction("Index");
            }
            return View(book);
        }

    }
}
