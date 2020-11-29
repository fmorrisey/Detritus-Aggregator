using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using TrashCollectorWebApp.Data;
using TrashCollectorWebApp.Models;
using TrashCollectorWebApp.Services;

namespace TrashCollectorWebApp.Controllers
{
    public class CustomerController : Controller
    {

        private ApplicationDbContext _dbContext;
        private decimal oneTimeCost = 10;
        private decimal PickUpCharge = 3;
        private decimal recurringCharge = 12;
        private GeocodingService geocoding;
        //private decimal reccuringCost = 3 * 4; // cost per pickup over weeks in a month

        public CustomerController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
            geocoding = new GeocodingService();
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
            
            ViewData["APIkey"] = AuthKeys.AuthKeys.Google_API_Key;

            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var customer = _dbContext.Customers.Where(c => c.IdentityUserId == userId).FirstOrDefault();

            if (customer == null)
            {
                return RedirectToAction(nameof(CreateProfile));
            }
            else
            {
                return View(customer);
            }


            

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
        public ActionResult CreateProfile()
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var customer = _dbContext.Customers.Where(c => c.IdentityUserId == userId).FirstOrDefault();
            return View(customer);
        }

        // POST: CustomerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> CreateProfile(Customer customer)
        {
            try
            {
                var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                customer.IdentityUserId = userId;
                customer = ChargeCustomer(customer, recurringCharge);
                customer = await geocoding.GetGeoCoding(customer);
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
        public async Task<ActionResult> Edit(int id, Customer customer)
        {
            try
            {
                customer = await geocoding.GetGeoCoding(customer);
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
