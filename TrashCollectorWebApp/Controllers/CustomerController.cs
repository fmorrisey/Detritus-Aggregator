using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using TrashCollectorWebApp.Data;
using TrashCollectorWebApp.Models;

namespace TrashCollectorWebApp.Controllers
{
    public class CustomerController : Controller
    {

        private ApplicationDbContext _dbContext;
        private decimal oneTimeCost = 10;
        //private decimal reccuringCost = 3 * 4; // cost per pickup over weeks in a month

        public CustomerController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        // GET: CustomerController
        public ActionResult Index()
        {
            var returnList = _dbContext.Customers.ToList();
            return View(returnList);
        }

        // GET: CustomerController/Details/5
        public ActionResult Details(int id)
        {
            var details = _dbContext.Customers.Find(id);
            return View(details);
        }

        // GET: CustomerController/Details/5
        public ActionResult AccountView(int id)
        {
            var details = _dbContext.Customers.Find(id);
            return View(details);
        }

        // Create profile
        #region
        // GET: CustomerController/Create
        public ActionResult CreateProfile(int id)
        {
            // Brings the current Customer profile
            var details = _dbContext.Customers.Find(id);
            return View(details);
        }

        // POST: CustomerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateProfile(Customer customer)
        {
            try
            {
                var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                customer.IdentityUserId = userId;

                //Scustomer = chargeCustomer(customer, reccuringCost);

                _dbContext.Customers.Add(customer);
                
                _dbContext.SaveChanges();

                return RedirectToAction(nameof(Index /*change me later*/));
            }
            catch
            {
                return View();
            }
        }
        #endregion


        // ChangePickUp
        #region
        // GET: CustomerController/ChangePickUp
        public ActionResult ChangePickUp(int id)
        {
            var customer = _dbContext.Customers.Find(id);

            return View(customer);
        }

        // POST: CustomerController/ChangePickUp
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ChangePickUp(int id, Customer customer)
        {
            try
            {
                _dbContext.Customers.Update(customer);
                _dbContext.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        #endregion

        // ChangePickUp - with PickUpTable
        #region
        // GET: CustomerController/ChangePickUp
        public ActionResult ChangePickUpTable(int id)
        {
            
            if (_dbContext.PickUp.Any(c => c.Customer_ID == id))
            {

                PickUp pickUp = _dbContext.PickUp.Find(id);
                return View(pickUp);
            }
            else
            {
                PickUp pickUp = new PickUp();
                pickUp.Customer_ID = id;
                return View(pickUp);
            }
        }

        // POST: CustomerController/ChangePickUp
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ChangePickUpTable(int id, Customer customer)
        {
            try
            {
                _dbContext.Customers.Update(customer);
                _dbContext.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        #endregion


        // Suspend
        #region
        // GET: CustomerController/Suspend
        public ActionResult Suspend(int id)
        {
            var editCustomer = _dbContext.Customers.Find(id);
            return View(editCustomer);
        }

        // POST: CustomerController/Suspend
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Suspend(int id, Customer customer)
        {
            try
            {
                _dbContext.Customers.Update(customer);
                _dbContext.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        #endregion

        // One Time
        #region
        // GET: CustomerController/Suspend
        public ActionResult OneTime(int id)
        {
            var editCustomer = _dbContext.Customers.Find(id);
            return View(editCustomer);
        }

        // POST: CustomerController/Suspend
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult OneTime(int id, Customer customer)
        {
            try
            {
                customer = isOneTime(customer);
                _dbContext.Customers.Update(customer);
                _dbContext.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        #endregion

        // Edit
        #region
        // GET: CustomerController/Edit/5
        public ActionResult Edit(int id)
        {
            var editCustomer = _dbContext.Customers.Find(id);
            return View(editCustomer);
        }

        // POST: CustomerController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Customer customer)
        {
            try
            {
                _dbContext.Customers.Update(customer);
                _dbContext.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        #endregion

        

        private Customer chargeCustomer(Customer customer, decimal charge)
        {
            customer.Balance += charge;
            return customer;
        }

        private Customer isOneTime(Customer customer)
        {
            if (customer.Customer_PickUp_OneTime != default)
            {
                customer.OneTimePickUp = true;
                customer = chargeCustomer(customer, oneTimeCost);
                return customer;
            }
            else
            {
                customer.OneTimePickUp = false;
                return customer;
            }
            
        }

        /*
        // GET: CustomerController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CustomerController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        */
    }
}
