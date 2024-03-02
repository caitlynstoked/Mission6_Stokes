using Mission6_Stokes.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace Mission6_Stokes.Controllers
{
    public class HomeController : Controller
    {
        private MovieEntryFormContext _context;

        public HomeController(MovieEntryFormContext temp)
        {
            _context = temp;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GetToKnow()
        {
            return View();
        }

        [HttpGet]
        public IActionResult MovieEntryForm()
        {
            ViewBag.Category = _context.Categories
                .OrderBy(x => x.CategoryId)
                .ToList();

            return View("MovieEntryForm");
        }

        [HttpPost]
        [HttpPost]
        public IActionResult MovieEntryForm(MovieEntryForm response)
        {
            if (ModelState.IsValid)
            {
                _context.Movies.Add(response);  
                _context.SaveChanges();

                return View("Succuss", response);
            }
            else
            {
                ViewBag.Categories = _context.Categories
                .OrderBy(x => x.CategoryName)
                .ToList();

                return View(response);
            }
        }

        public IActionResult MovieList()
        {

            return View();

        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var recordToEdit = _context.Movies
                .Single(x => x.MovieId == id); 

            ViewBag.Categories = _context.Categories
                .OrderBy(x => x.CategoryName)
                .ToList();


            return View("MovieEntryForm", recordToEdit);
        }

        [HttpPost]
        public IActionResult Edit(MovieEntryForm UpdatedInfo)
        {
            _context.Update(UpdatedInfo);
            _context.SaveChanges();

            return RedirectToAction("MovieList");
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var recordToDelete = _context.Movies
                .Single(x => x.MovieId == id);
            ViewBag.Categories = _context.Categories
            .OrderBy(x => x.CategoryName)
            .ToList();

            return View(recordToDelete);
        }

        [HttpPost]
        public IActionResult Delete(MovieEntryForm Delete)
        {
            _context.Remove(Delete);
            _context.SaveChanges();

            return RedirectToAction("MovieList");
        }

    }
}