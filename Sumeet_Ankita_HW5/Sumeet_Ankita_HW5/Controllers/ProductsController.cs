using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Sumeet_Ankita_HW5.DAL;
using Sumeet_Ankita_HW5.Models;
using Microsoft.AspNetCore.Authorization;

namespace Sumeet_Ankita_HW5.Controllers
{
    public class ProductsController : Controller
    {
        private readonly AppDbContext _context;

        public ProductsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Products
        public async Task<IActionResult> Index()
        {
              return View(await _context.Products.ToListAsync());
        }

        // GET: Products/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Products == null)
            {
                return NotFound();
            }

            var product = await _context.Products
                .Include(c => c.Suppliers)
                .FirstOrDefaultAsync(m => m.ProductID == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        private SelectList GetAllSuppliersSelectList()
        {
            //Get the list of months from the database
            List<Supplier> supplierList = _context.Suppliers.ToList();


            //convert the list to a SelectList by calling SelectList constructor
            //MonthID and MonthName are the names of the properties on the Month class
            //MonthID is the primary key
            SelectList supplierSelectList = new SelectList(supplierList.OrderBy(m => m.SupplierID), "SupplierID", "SupplierName");

            //return the electList
            return supplierSelectList;
        }



        private MultiSelectList GetAllSuppliersSelectList(Product product)
        {
            //Create a new list of departments and get the list of the departments
            //from the database
            List<Supplier> allSuppliers = _context.Suppliers.ToList();

            //loop through the list of course departments to find a list of department ids
            //create a list to store the department ids
            List<Int32> selectedSupplierIDs = new List<Int32>();

            //Loop through the list to find the DepartmentIDs
            foreach (Supplier associatedSupplier in product.Suppliers)
            {
                selectedSupplierIDs.Add(associatedSupplier.SupplierID);
            }

            //use the MultiSelectList constructor method to get a new MultiSelectList
            MultiSelectList mslAllSuppliers = new MultiSelectList(allSuppliers.OrderBy(d => d.SupplierName), "SupplierID", "SupplierName", selectedSupplierIDs);

            //return the MultiSelectList
            return mslAllSuppliers;
        }

        // GET: Products/Create
        [Authorize(Roles = "Admin")]
        public IActionResult Create()
        {
            ViewBag.AllSuppliers = GetAllSuppliersSelectList();
            return View();
        }



        // POST: Products/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProductID,ProductName,ProductDescription,ProductPrice,ProductType")] Product product, int[] SelectedSuppliers)
        {

            {
                //This code has been modified so that if the model state is not valid
                //we immediately go to the "sad path" and give the user a chance to try again
                if (ModelState.IsValid == false)
                {
                    //re-populate the view bag with the departments
                    ViewBag.AllSuppliers = GetAllSuppliersSelectList();
                    //go back to the Create view to try again
                    return View(product);
                }

                //if code gets to this point, we know the model is valid and
                //we can add the course to the database

                //add the course to the database and save changes
                _context.Add(product);
                await _context.SaveChangesAsync();

                //add the associated departments to the course
                //loop through the list of deparment ids selected by the user
                foreach (int supplierID in SelectedSuppliers)
                {
                    //find the department associated with that id
                    Supplier dbSupplier = _context.Suppliers.Find(supplierID);

                    //add the department to the course's list of departments and save changes
                    product.Suppliers.Add(dbSupplier);
                    _context.SaveChanges();
                }

                //Send the user to the page with all the departments
                return RedirectToAction(nameof(Index));
            }
        }

        // GET: Products/Edit/5
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Products == null)
            {
                return NotFound();
            }

            var product = await _context.Products.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            ViewBag.AllSuppliers = GetAllSuppliersSelectList();
            return View(product);
        }

        // POST: Products/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public IActionResult Edit(int id, [Bind("ProductID,Name,Description,Price,ProductType")] Product product, int[] SelectedSuppliers)
        {

            //this is a security check to see if the user is trying to modify
            //a different record.  Show an error message
            if (id != product.ProductID)
            {
                return View("Error", new string[] { "Please try again!" });
            }

            if (ModelState.IsValid == false) //there is something wrong
            {
                ViewBag.AllSuppliers = GetAllSuppliersSelectList(product);
                return View(product);
            }

            //if code gets this far, attempt to edit the product
            try
            {

                Product dbProduct = _context.Products.Include(c => c.Suppliers).FirstOrDefault(c => c.ProductID == product.ProductID);

                List<Supplier> SuppliersToRemove = new List<Supplier>();

                foreach (Supplier supplier in dbProduct.Suppliers)
                {
                    //see if the new list contains the supplier id from the old list
                    if (SelectedSuppliers.Contains(supplier.SupplierID) == false)//this supplier is not on the new list
                    {
                        SuppliersToRemove.Add(supplier);
                    }
                }

                //remove the suppliers you found in the list above
                //this has to be 2 separate steps because you can't iterate (loop)
                //over a list that you are removing things from
                foreach (Supplier supplier in SuppliersToRemove)
                {
                    //remove this product supplier from the product's list of suppliers
                    dbProduct.Suppliers.Remove(supplier);
                    _context.SaveChanges();
                }

                //add the suppliers that aren't already there
                foreach (int supplierID in SelectedSuppliers)
                {
                    if (dbProduct.Suppliers.Any(d => d.SupplierID == supplierID) == false)//this department is NOT already associated with this course
                    {
                        //Find the associated supplier in the database
                        Supplier dbSupplier = _context.Suppliers.Find(supplierID);

                        //Add the supplier to the product's list of suppliers
                        dbProduct.Suppliers.Add(dbSupplier);
                        _context.SaveChanges();
                    }
                }

                //update the product's scalar properties
                dbProduct.ProductName = product.ProductName;
                dbProduct.ProductPrice = product.ProductPrice;
                dbProduct.Description = product.Description;
                dbProduct.ProductType = product.ProductType;

                //save the changes
                _context.Products.Update(dbProduct);
                _context.SaveChanges();

            }
            catch (Exception ex)
            {
                return View("Error", new string[] { "There was an error editing this course.", ex.Message });
            }

            return RedirectToAction(nameof(Index));

        }

    }

}
