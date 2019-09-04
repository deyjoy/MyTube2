using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyTube2.Models;
using MyTube2.ViewModels;

namespace MyTube2.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };
            var customers = new List<Customer>
            {
                new Customer {  Name = "Abhi Bhowmick" , Id = 1001},
                new Customer {  Name = "Shuvro Kanti Das" , Id = 1002}
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers                
            };

            return View(viewModel);
        }    
    }
}