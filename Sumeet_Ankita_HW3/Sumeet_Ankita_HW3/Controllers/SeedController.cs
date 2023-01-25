using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//TODO: Change this using statement to match your project (LastName_FirstName_HW3)
using Sumeet_Ankita_HW3.DAL;
using Microsoft.AspNetCore.Mvc;


//TODO: Update this namespace to match your project's name
namespace Sumeet_Ankita_HW3.Controllers
{
    public class SeedController : Controller
    {
        private AppDbContext _db;

        public SeedController(AppDbContext context)
        {
            _db = context;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SeedLanguages()
        {
            try
            {
                Seeding.SeedLanguages.SeedAllLanguages(_db);
            }
            catch (Exception ex)
            {
                //create a new list to hold all the errors
                List<String> errors = new List<String>();

                //add a generic message
                errors.Add("There was an error adding genres to the database!");

                //add the message from the exception
                errors.Add(ex.Message);

                //add messages from inner exceptions (if there are any)
                if (ex.InnerException != null)
                {
                    errors.Add(ex.InnerException.Message);
                    if (ex.InnerException.InnerException != null)
                    {
                        errors.Add(ex.InnerException.InnerException.Message);
                        if (ex.InnerException.InnerException.InnerException != null)
                        {
                            errors.Add(ex.InnerException.InnerException.InnerException.Message);
                        }
                    }
                }

                //return the error message with the list of errors
                return View("Error", errors);
            }

            //everything is okay - return the confirmation page
            return View("Confirm");
        }

        public IActionResult SeedRepositories()
        {
            try
            {
                Seeding.SeedRepositories.SeedAllRepositories(_db);
            }
            catch (Exception ex)
            {
                //create a new list for the error messages
                List<String> errors = new List<String>();

                //add a generic error message
                errors.Add("There was a problem adding repositories to the database");

                //add message from the exception
                errors.Add(ex.Message);

                //add messages from inner exceptions, if there are any
                if (ex.InnerException != null)
                {
                    errors.Add(ex.InnerException.Message);
                    if (ex.InnerException.InnerException != null)
                    {
                        errors.Add(ex.InnerException.InnerException.Message);
                        if (ex.InnerException.InnerException.InnerException != null)
                        {
                            errors.Add(ex.InnerException.InnerException.InnerException.Message);
                        }
                    }
                }

                //return the error view with the errors
                return View("Error", errors);
            }

            //everything is okay - return the confirmation page
            return View("Confirm");
        }
    }
}

