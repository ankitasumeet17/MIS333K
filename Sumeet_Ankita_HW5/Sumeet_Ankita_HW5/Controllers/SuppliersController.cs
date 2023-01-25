using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Sumeet_Ankita_HW5.DAL;
using Sumeet_Ankita_HW5.Models;

namespace Sumeet_Ankita_HW5.Controllers
{
    [Authorize(Roles = "Admin")]
    public class SuppliersController : Controller
    {
        private readonly AppDbContext _context;

        public SuppliersController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Suppliers

            [Authorize(Roles = "Admin")]

            public async Task<IActionResult> Index()

            {
                return View(await _context.Suppliers.ToListAsync());

            }

            // GET: Suppliers/Details/5

            public async Task<IActionResult> Details(int? id)

            {

                if (id == null)
                {
                    return View("Error", new String[] { "Please specify a supplier to view!" });
                }

                //find the supplier in the database
                Supplier supplier = await _context.Suppliers
                .Include(d => d.Products)
                .FirstOrDefaultAsync(m => m.SupplierID == id);

                //if the supplier is not in the database, show the user an error
                if (supplier == null)
                {
                    return View("Error", new String[] { "This supplier was not found!" });
                }

                //show the user the details for this supplier
                return View(supplier);

            }

            // GET: Suppliers/Create

            public IActionResult Create()

            {

                return View();

            }

            // POST: Suppliers/Create

            // To protect from overposting attacks, enable the specific properties you want to bind to.

            // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.

            [HttpPost]

            [ValidateAntiForgeryToken]

            public async Task<IActionResult> Create([Bind("SupplierID,SupplierName,Email,PhoneNumber")] Supplier supplier)

            {

                if (ModelState.IsValid)

                {

                    _context.Add(supplier);

                    await _context.SaveChangesAsync();

                    return RedirectToAction(nameof(Index));

                }

                return View(supplier);

            }

            // GET: Suppliers/Edit/5

            public async Task<IActionResult> Edit(int? id)

            {

                //user did not specify a department to edit            
                if (id == null)
                {
                    return View("Error", new String[] { "Please specify a supplier to edit!" });
                }

                //find the department in the database
                Supplier supplier = await _context.Suppliers.FindAsync(id);

                //see if the department exists in the database
                if (supplier == null)
                {
                    return View("Error", new String[] { "This supplier does not exist in the database!" });
                }

                //send the user to the edit department page
                return View(supplier);

            }

            // POST: Suppliers/Edit/5

            // To protect from overposting attacks, enable the specific properties you want to bind to.

            // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.

            [HttpPost]

            [ValidateAntiForgeryToken]

            public async Task<IActionResult> Edit(int id, [Bind("SupplierID,SupplierName,Email,PhoneNumber")] Supplier supplier)

            {

                //this is a security measure to make sure they are editing the correct department
                if (id != supplier.SupplierID)
                {
                    return View("Error", new String[] { "There was a problem editing this supplier. Try again!" });
                }

                //if the user messed up, send them back to the view to try again
                if (ModelState.IsValid == false)
                {
                    return View(supplier);
                }

                //if code gets this far, make the updates
                try
                {
                    _context.Update(supplier);
                    await _context.SaveChangesAsync();
                }
                catch (Exception ex)
                {
                    return View("Error", new String[] { "There was a problem editing this supplier.", ex.Message });
                }

                //send the user back to the view with all the departments
                return RedirectToAction(nameof(Index));

            }

        }

    }