using BookApplication.Data;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Data.Entity;
using Microsoft.EntityFrameworkCore;


namespace BookApplication.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

       

    }
}
