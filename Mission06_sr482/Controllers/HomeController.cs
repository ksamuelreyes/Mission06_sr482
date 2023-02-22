using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Mission06_sr482.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

//Sam Reyes | Section 03
namespace Mission06_sr482.Controllers
{
    public class HomeController : Controller
    {

        private MoviesContext _MoviesContext { get; set; }

        public HomeController(MoviesContext movies)
        {
            _MoviesContext = movies;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Podcast()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Movies()
        {
            ViewBag.Categories = _MoviesContext.Categories.ToList();
 

            return View();
        }
        public IActionResult MovieTable()
        {
            var applications = _MoviesContext.responses.Include(x => x.Category).ToList();

            return View(applications);
        }

        [HttpPost]
        public IActionResult Movies(ApplicationResponse ar)
        {
            if (ModelState.IsValid)
            {
                _MoviesContext.Add(ar);
                _MoviesContext.SaveChanges();

                return View("Confirmation", ar);
            }
            else
            {
                ViewBag.Categories = _MoviesContext.Categories.ToList();

                return View(ar);
            }


        }
        [HttpGet]
        public IActionResult Edit(int movieid)
        {
            ViewBag.Categories = _MoviesContext.Categories.ToList();

            var application = _MoviesContext.responses.Single(x => x.MovieID == movieid);

            return View("Movies", application);
        }
        [HttpPost]
        public IActionResult Edit(ApplicationResponse ar)
        {
            if (ModelState.IsValid)
            {
                _MoviesContext.Update(ar);
                _MoviesContext.SaveChanges();

                return RedirectToAction("MovieTable", ar);
            }
            else
            {
                ViewBag.Categories = _MoviesContext.Categories.ToList();
                return View("Movies");
            }

        }
        [HttpGet]
        public IActionResult Delete(int movieid)
        {
            var movie = _MoviesContext.responses.Single(x => x.MovieID == movieid);
            return View(movie);
        }
        [HttpPost]
        public IActionResult Delete(ApplicationResponse ar)
        {
            _MoviesContext.responses.Remove(ar);
            _MoviesContext.SaveChanges();
            return RedirectToAction("MovieTable");
        }
    }
}
