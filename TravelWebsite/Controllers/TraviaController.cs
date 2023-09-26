using Microsoft.AspNetCore.Mvc;
using System.Collections;
using TravelWebsite.Data;
using TravelWebsite.Models;

namespace TravelWebsite.Controllers
{
    public class TraviaController : Controller
    {
        private readonly ApplicationDbContext _dbcontext;

        public TraviaController(ApplicationDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Tours()
        {
            List<ToursModel> Tours = _dbcontext.Tours.ToList();
            return View(Tours);
        }

        [HttpGet]
        public IActionResult Destinations()
        {
            List<DestinationsModel> destinations = _dbcontext.Destinations.ToList();

            return View(destinations);
        }

        [HttpGet]
        public IActionResult Contact()
        {
            ViewBag.Company = _dbcontext.Company.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Contact(ContactModel contact)
        {
            if(ModelState.IsValid)
            {
                _dbcontext.Contact.Add(contact);
                _dbcontext.SaveChanges();

                return RedirectToAction(nameof(Contact));
            }

            return View();
        }
    }
}
