using Microsoft.AspNetCore.Mvc;
using Mission6_Stokes.Models;
using System.Diagnostics;

namespace Mission6_Stokes.Controllers
{
    public class HomeController : Controller
    {
        private Mission6Context _context;

        public HomeController(Mission6Context  temp)
        {
            _context = temp;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Mission6()
        {
            return View();
        }
        public IActionResult GetToKnow()
        {
            return View();
        }

        [HttpGet]

        public IActionResult Mission6(ApplicationBuilder response)
        {
            //_context.Applications.Add(response); //add record to the database
            _context.SaveChanges();

            return View("Confirmation", response);
        }

        [HttpPost]

        public IActionResult Mission6(Class response)
        {
            return View("Confirmation", response);
        }

    }
}
