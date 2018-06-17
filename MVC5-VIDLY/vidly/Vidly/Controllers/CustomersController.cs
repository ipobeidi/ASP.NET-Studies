using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Vidly.Models;
using System.Data.Entity;
using Vidly.ViewModels;
using System.Data.Entity.Validation;
using System;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        private ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ViewResult Index()
        {
            
            return View();
         }

        public ActionResult Details(int id)
        {

            var customer = _context.Customers.Include(c => c.MembershipType).SingleOrDefault(c => c.Id == id);

            if (customer == null)
                return HttpNotFound();

            return View(customer);
        }

        [HttpPost]
        public ActionResult Save(CustomerFormViewModel customerview)
        {
            if (!ModelState.IsValid)
            {
                var viewmodel = new CustomerFormViewModel
                {
                    Customers = customerview.Customers,
                    Membershiptypes = _context.MembershipTypes.ToList()
                };
                return View("CustomerForm", viewmodel);

            }

            if (customerview.Customers.Id == 0)
            {
                _context.Customers.Add(customerview.Customers);
            }
            else
            {
                var customerinDB = _context.Customers.Single(c => c.Id == customerview.Customers.Id);
                customerinDB.Name = customerview.Customers.Name;
                customerinDB.Birthday = customerview.Customers.Birthday;
                customerinDB.MembershipTypeId = customerview.Customers.MembershipTypeId;
                customerinDB.IsSubscribedToNewsLetter = customerview.Customers.IsSubscribedToNewsLetter;
            }
            _context.SaveChanges();
            return RedirectToAction("Index", "Customers");
        }
        public ActionResult New()
        {
            var membershipType = _context.MembershipTypes.ToList();

            var viewModels = new CustomerFormViewModel
            {
                Customers = new Customer(),
                Membershiptypes = membershipType
            };

            return View("CustomerForm", viewModels);
        }
        public ActionResult Edit(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            var viewmodel = new CustomerFormViewModel
            {
                Customers = customer,
                Membershiptypes = _context.MembershipTypes.ToList()
            };

            return View("CustomerForm", viewmodel);
        }

    }

}