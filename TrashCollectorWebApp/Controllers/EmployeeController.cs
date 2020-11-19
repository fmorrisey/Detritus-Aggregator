using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Claims;
using TrashCollectorWebApp.Data;
using TrashCollectorWebApp.Models;
using TrashCollectorWebApp.Models.viewModels;
using Microsoft.EntityFrameworkCore;

namespace TrashCollectorWebApp.Controllers
{
    public class EmployeeController : Controller
    {

        private ApplicationDbContext _dbContext;
        private string Today = "M";
        private decimal PickUpCharge = 3;

        public EmployeeController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }



        public async Task<IActionResult> Index(string sortOrder, string searchString)
        {
            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewBag.ZipSortParm = sortOrder == "Zip_Asc" ? "Zip_Desc" : "Zip_Asc";
            ViewBag.DateSortParm = String.IsNullOrEmpty(sortOrder) ? "Date_Desc" : "";
            var customers = from s in _dbContext.Customers
                            select s;
            if (!String.IsNullOrEmpty(searchString))
            {
                customers = customers.Where(s => s.LastName.Contains(searchString));

            }

            switch (sortOrder)
            {
                case "name_desc":
                    customers = customers.OrderByDescending(s => s.LastName);
                    break;
                case "Zip_Asc":
                    customers = customers.OrderBy(s => s.Zip);
                    break;
                case "Zip_Desc":
                    customers = customers.OrderByDescending(s => s.Zip);
                    break;
                case "Date_Asc":
                    customers = customers.OrderBy(s => s.Customer_PickUp_Reccuring);
                    break;
                case "Date_Desc":
                    customers = customers.OrderByDescending(s => s.Customer_PickUp_Reccuring);
                    break;
                default:
                    customers = customers.OrderBy(s => s.LastName);
                    break;
            }
            return View(await customers.AsNoTracking().ToListAsync());
        }


        public async Task<IActionResult> CustomerList(string sortOrder, string searchString)
        {
            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewBag.ZipSortParm = sortOrder == "Zip_Asc" ? "Zip_Desc" : "Zip_Asc";
            ViewBag.DateSortParm = String.IsNullOrEmpty(sortOrder) ? "Date_Desc" : "";
            var customers = from s in _dbContext.Customers
                            select s;
            if (!String.IsNullOrEmpty(searchString))
            {
                customers = customers.Where(s => s.LastName.Contains(searchString));

            }

            switch (sortOrder)
            {
                case "name_desc":
                    customers = customers.OrderByDescending(s => s.LastName);
                    break;
                case "Zip_Asc":
                    customers = customers.OrderBy(s => s.Zip);
                    break;
                case "Zip_Desc":
                    customers = customers.OrderByDescending(s => s.Zip);
                    break;
                case "Date_Asc":
                    customers = customers.OrderBy(s => s.Customer_PickUp_Reccuring);
                    break;
                case "Date_Desc":
                    customers = customers.OrderByDescending(s => s.Customer_PickUp_Reccuring);
                    break;
                default:
                    customers = customers.OrderBy(s => s.LastName);
                    break;
            }
            return View(await customers.AsNoTracking().ToListAsync());
        }

        // GET: EmployeeController
        public ActionResult PickUpToday()
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var employee = _dbContext.Employees.Where(c => c.IdentityUserId ==
            userId).SingleOrDefault();

            var viewModel = new List<Customer>();

            viewModel = _dbContext.Customers.Where(c => c.Customer_PickUp_Reccuring == Today)
                .OrderByDescending(c => c.Zip == employee.Zip)
                .ToList();

            return View(viewModel);
        }

        // GET: EmployeeController/Details/5
        public ActionResult CusomterDetails(int id)
        {
            var details = _dbContext.Customers.Find(id);
            return View(details);
        }

        // GET: EmployeeController/Create
        public ActionResult Create(int id)
        {
            var details = _dbContext.Employees.Find(id);
            return View(details);
        }

        // POST: EmployeeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Employee employee)
        {
            try
            {
                var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                employee.IdentityUserId = userId;

                _dbContext.Employees.Add(employee);
                _dbContext.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }



        [HttpGet]
        [HttpPost]
        public ActionResult ConfirmPickUp(int id )
        {

            var customer = _dbContext.Customers.Find(id);
            customer = PickUpConfirmed(customer);
            _dbContext.Customers.Update(customer);
            _dbContext.SaveChanges();

            return RedirectToAction(nameof(PickUpToday));
        }
        

        private Customer chargeCustomer(Customer customer, decimal charge)
        {
            customer.Balance += charge;
            return customer;
        }

        private Customer PickUpConfirmed(Customer customer)
        {
            if (customer.ConfirmPickUp != true)
            {
                customer.ConfirmPickUp = true;
                customer = chargeCustomer(customer, PickUpCharge);
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
