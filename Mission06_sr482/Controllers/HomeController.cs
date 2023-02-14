using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mission06_sr482.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mission06_sr482.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private MoviesContext _MoviesContext { get; set; }

        public HomeController(ILogger<HomeController> logger, MoviesContext movies)
        {
            _logger = logger;
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
            return View();
        }

        [HttpPost]
        public IActionResult Movies(ApplicationResponse ar)
        {
            _MoviesContext.Add(ar);
            _MoviesContext.SaveChanges();
            return View("Confirmation", ar);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
