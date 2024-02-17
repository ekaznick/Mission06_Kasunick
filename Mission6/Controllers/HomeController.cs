using Microsoft.AspNetCore.Mvc;
using Mission06_Kasunick.Models;
using System.Diagnostics;

namespace Mission06_Kasunick.Controllers
{
    public class HomeController : Controller
    {

        private MoviesContext _context;
        public HomeController(MoviesContext temp) //Constructor
        { 
            _context = temp;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Joel()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Movies()
        {
            return View(); 
        }

        [HttpPost]
        public IActionResult Movies(Movies response)
        {
            _context.Movies.Add(response); //Add record to database
            _context.SaveChanges();

            return View("Confirmation", response);
        }
    }
}
