using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Security.Claims;
using TrashCollectorWebApp.Data;
using TrashCollectorWebApp.Models;

namespace TrashCollectorWebApp.Controllers
{
    public class CustomerController : Controller
    {

        private ApplicationDbContext _dbContext;
        private decimal oneTimeCost = 10;
        private decimal PickUpCharge = 3;
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

        public ActionResult Details()
        {
            ViewData["MyKey"] = "AIzaSyBaeUmClRSBgp2dqGzpAgq8RpwsgwjQmUs";

            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var customer = _dbContext.Customers.Where(c => c.IdentityUserId == userId).FirstOrDefault();

            return View(customer);

        }

        // GET: CustomerController/Details/5
        public ActionResult AccountView()
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var customer = _dbContext.Customers.Where(c => c.IdentityUserId == userId).FirstOrDefault();
            return View(customer);
        }


        // Create profile
        #region
        // GET: CustomerController/Create
        [HttpGet]
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

                _dbContext.Customers.Add(customer);

                _dbContext.SaveChanges();

                return RedirectToAction(nameof(Details /*change me later*/));
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
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var customer = _dbContext.Customers.Where(c => c.IdentityUserId == userId).FirstOrDefault();
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
                return RedirectToAction(nameof(Details));
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
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var customer = _dbContext.Customers.Where(c => c.IdentityUserId == userId).FirstOrDefault();
            return View(customer);
        }

        // POST: CustomerController/Suspend
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Suspend(int id, Customer customer)
        {
            try
            {
                customer = RefundCustomer(customer, PickUpCharge);
                _dbContext.Customers.Update(customer);
                _dbContext.SaveChanges();
                return RedirectToAction(nameof(Details));
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
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var customer = _dbContext.Customers.Where(c => c.IdentityUserId == userId).FirstOrDefault();
            return View(customer);
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
                return RedirectToAction(nameof(Details));
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
        public ActionResult Edit()
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var customer = _dbContext.Customers.Where(c => c.IdentityUserId == userId).FirstOrDefault();
            return View(customer);
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

        private Customer ChargeCustomer(Customer customer, decimal charge)
        {
            customer.Balance += charge;
            return customer;
        }

        private Customer RefundCustomer(Customer customer, decimal charge)
        {
            if (customer.Balance <= 0)
            {
                return customer;
            }
            else
            {
                customer.Balance -= charge;
                return customer;
            }

        }

        private Customer isOneTime(Customer customer)
        {
            if (customer.Customer_PickUp_OneTime != default)
            {
                customer.OneTimePickUp = true;
                customer = ChargeCustomer(customer, oneTimeCost);
                return customer;
            }
            else
            {
                customer.OneTimePickUp = false;
                return customer;
            }

        }

    }
}
