using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Data.Entity;
using Vidly.Models;
using Vidly.DTO;

namespace Vidly.Controllers.Api
{
    public class NewRentalController : ApiController 
    {
        private ApplicationDbContext _context;


        public NewRentalController()
        {
            _context = new ApplicationDbContext();
        }
        [HttpPost]
        public  IHttpActionResult CreateNewRental (NewRentalDTO newRental)
        {
            
            var customer = _context.Customers.Single(c => c.Id == newRental.CustomerId);
                     
            
            var movies = _context.Movies.Where(m => newRental.MovieIds.Contains(m.Id)).ToList();
                       
            foreach (var movie in movies)
            {
                if (movie.NumberInStock == 0)
                    return BadRequest("Movie is not available");

                movie.NumberInStock--;
                var rental = new Rental
                {
                    Customer = customer,
                    Movie = movie,
                    DataRented = DateTime.Now
                };
                _context.Rentals.Add(rental);
            }
            _context.SaveChanges();

            return Ok();
        }
    }
}