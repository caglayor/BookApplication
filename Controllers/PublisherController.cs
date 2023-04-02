using BookApplication.Data;
using Microsoft.AspNetCore.Mvc;

namespace BookApplication.Controllers
{
    public class PublisherController : Controller
    {
        ApplicationDbContext DbContext { get; set; }
        public PublisherController(ApplicationDbContext dbContext) { 
            this.DbContext = dbContext;

        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details(int id) {
            var publisher = DbContext.Publishers.Find(id);
            if(publisher == null)
            {
                return NotFound();
            }
            return Content(publisher.Name);
            
        }
    }
}
