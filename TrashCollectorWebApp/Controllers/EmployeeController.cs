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

namespace TrashCollectorWebApp.Controllers
{
    public class EmployeeController : Controller
    {

        private ApplicationDbContext _dbContext;
        private string Today = "M";

        public EmployeeController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public ActionResult Index()
        {
            var returnList = _dbContext.Employees.ToList();
            return View(returnList);
        }


        // GET: EmployeeController
        public ActionResult CustomerList()
        {
            var returnList = _dbContext.Customers.ToList();
            return View(returnList);

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

        // GET: EmployeeController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EmployeeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
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

        // GET: EmployeeController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EmployeeController/Delete/5
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
    }
}
