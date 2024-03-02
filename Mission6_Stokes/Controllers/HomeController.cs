using Mission6_Stokes.Models;
using Microsoft.AspNetCore.Mvc;
uisng Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace Mission6_Stokes.Controllers
{
    public class HomeController : Controller
    {
        private MovieEntryFormContext _context;

        public HomeController(MovieEntryFormContext  temp)
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
            ViewBag.Category = _context.Category
                .OrderBy(x => x.CategoryId)
                .ToList();

            return View("MovieEntryForm");
        }

        [HttpPost]
        public IActionResult MovieEntryForm(MovieEntryForm response)
        {
            _context.Applications.Add(response); //add record to the database
            _context.SaveChanges();

            return View("Confirmation", response);
        }


        [HttpPost]

        public IActionResult Mission6(Class response)
        {
            return View("Confirmation", response);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {

            ViewBag.Categories = _repo.Category
                .OrderBy(x => x.CategoryId)
                .ToList();


            return View("AddOrEdit", RecordToEdit);
        }

        [HttpPost]
        public IActionResult Edit(MovieEntryForm UpdatedInfo)
        {
            _repo.Edit(UpdatedInfo);
            return RedirectToAction("QTest");
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var recordToDelete = _context.Applications
                .Single(x=> x.MovieId == id);

            return View(recordToDelete);
        }

        [HttpPost]
        
        public IActionResult Delete(MovieEntryForm application)
        {
            _context.Applications.Remove(application);
            _context.SaveChanges();

            return RedirectToAction("MovieList");
        }

    }
}
