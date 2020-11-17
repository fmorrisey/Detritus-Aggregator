using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TrashCollectorWebApp.Data;
using TrashCollectorWebApp.Models;

namespace TrashCollectorWebApp.Controllers
{
    public class Customer_PickUpController : Controller
    {
        private readonly ApplicationDbContext _context;

        public Customer_PickUpController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Customer_PickUp
        public async Task<IActionResult> Index()
        {
            return View(await _context.Customer_PickUp.ToListAsync());
        }

        // GET: Customer_PickUp/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer_PickUp = await _context.Customer_PickUp
                .FirstOrDefaultAsync(m => m.PickUp_ID == id);
            if (customer_PickUp == null)
            {
                return NotFound();
            }

            return View(customer_PickUp);
        }

        // GET: Customer_PickUp/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Customer_PickUp/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PickUp_ID,ReccuringPickUp,OneTimePickUp")] Customer_PickUp customer_PickUp)
        {
            if (ModelState.IsValid)
            {
                _context.Add(customer_PickUp);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(customer_PickUp);
        }

        // GET: Customer_PickUp/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer_PickUp = await _context.Customer_PickUp.FindAsync(id);
            if (customer_PickUp == null)
            {
                return NotFound();
            }
            return View(customer_PickUp);
        }

        // POST: Customer_PickUp/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PickUp_ID,ReccuringPickUp,OneTimePickUp")] Customer_PickUp customer_PickUp)
        {
            if (id != customer_PickUp.PickUp_ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(customer_PickUp);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Customer_PickUpExists(customer_PickUp.PickUp_ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(customer_PickUp);
        }

        // GET: Customer_PickUp/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer_PickUp = await _context.Customer_PickUp
                .FirstOrDefaultAsync(m => m.PickUp_ID == id);
            if (customer_PickUp == null)
            {
                return NotFound();
            }

            return View(customer_PickUp);
        }

        // POST: Customer_PickUp/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var customer_PickUp = await _context.Customer_PickUp.FindAsync(id);
            _context.Customer_PickUp.Remove(customer_PickUp);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Customer_PickUpExists(int id)
        {
            return _context.Customer_PickUp.Any(e => e.PickUp_ID == id);
        }
    }
}
