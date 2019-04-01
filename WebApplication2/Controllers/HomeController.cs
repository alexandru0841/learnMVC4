using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        private OdeToFoodDB _db = new OdeToFoodDB();

        public ActionResult Index(string searchTerm = null)
        {

            //var myList = _db.Restaurants.ToList();
            var model = _db.Restaurants.Include(nameof(Restaurant.Reviews))
                       .OrderByDescending(r => r.Reviews.Average(review => review.Rating))
                       .Where(r=>searchTerm == null || r.Name.StartsWith(searchTerm))
                       .Take(10)
                       .Select(r => new restaurantListViewModel
                       {
                           Id =r.Id,
                           Name = r.Name,
                           City = r.City,
                           Country = r.Country,
                          
                       }
                       );

            //if (_db.Database.Exists())
            //{

                        //}
                        //else
                        //{
                        //    _db.Database.Initialize(true);
                        //    model = _db.Restaurants.ToList();
                        //}


            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        protected override void Dispose(bool disposing)
        {
            if (_db != null)
            {
                _db.Dispose();
            }

            base.Dispose(disposing);
        }
    }
}