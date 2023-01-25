using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sumeet_Ankita_HW3.DAL;
using Sumeet_Ankita_HW3.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Drawing;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Sumeet_Ankita_HW3.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext _context;

        public HomeController(AppDbContext dbContext)
        {
            _context = dbContext;
        }

        // GET: /<controller>/
        public IActionResult Index(String SearchString)
        {
            var query = from r in _context.Repositories
                        select r;

            if (String.IsNullOrEmpty(SearchString) == false)
            {
                query = query.Where(r => r.RepositoryName.Contains(SearchString) ||
                                      r.Description.Contains(SearchString));
            }

            List<Repository> SelectedRepositories = query.Include(r => r.Language).ToList();

            //Populate the view bag with a count of all repositories 
            ViewBag.AllRepositories = _context.Repositories.Count();

            //Populate the view bag with a count of selected repositories 
            ViewBag.SelectedRepositories = SelectedRepositories.Count();

            return View(SelectedRepositories.OrderByDescending(r => r.StarCount));

        }



        public IActionResult Details(int? id)//id is the id of the repo you want to see 
        {
            if (id == null) //RepositoryID not specified 
            {
                //user did not specify a RepositoryID – take them to the error view 
                return View("Error", new String[] { "RepositoryID not specified - which repository do you want to view ? " });
            }

            //look up the repo in the database based on the id; 
            // be sure to include the language 
            Repository repository = _context.Repositories.Include(b => b.Language).FirstOrDefault(b => b.RepositoryID == id);

            if (repository == null) //No repository with this id exists in the database 
            {
                //there is not a repository with this id in the database – show an error 
                return View("Error", new String[] { "Repository not found in database" });
            }

            //if code gets this far, all is well – display the details 
            return View(repository);
        }

        private SelectList GetAllLanguagesSelectList()
        {
            //Get the list of Languages from the database
            List<Language> LanguageList = _context.Languages.ToList();

            //add a dummy entry so the user can select all Languages
            Language SelectNone = new Language() { LanguageID = 0, LanguageName = "All Languages" };
            LanguageList.Add(SelectNone);

            //convert the list to a SelectList by calling SelectList constructor
            //LanguageID and LanguageName are the names of the properties on the Language class
            //LanguageID is the primary key
            SelectList languageSelectList = new SelectList(LanguageList.OrderBy(m => m.LanguageID), "LanguageID", "LanguageName");

            //return the electList
            return languageSelectList;
        }

        public IActionResult DetailedSearch()
        {
            ViewBag.AllLanguages = GetAllLanguagesSelectList();
            return View("DetailedSearch");
        }

        public IActionResult DisplaySearchResults(SearchViewModel svm)
        {
            var query = from r in _context.Repositories
                        select r;

            // Check Title
            if (svm.Title != null)
            {
                query = query.Where(r => r.RepositoryName.Contains(svm.Title));
            }

            // Check Description
            if (svm.Description != null)
            {
                query = query.Where(r => r.Description.Contains(svm.Description));
            }

            // Check Category
            if (svm.Category != null)
            {
                query = query.Where(r => r.Category == svm.Category);
            }

            // Check Language
            if (svm.SearchLanguage != 0)
            {
                Language LangToDisplay = _context.Languages.Find(svm.SearchLanguage);
                query = query.Where(r => r.Language == LangToDisplay);
            }

            // Check Star Count Greater Than
            if (svm.StarCount != null && svm.SearchType == SearchType.GreaterThan)
            {
                query = query.Where(r => r.StarCount >= svm.StarCount);
            }

            // Check Star Count Less Than
            if (svm.StarCount != null && svm.SearchType == SearchType.LessThan)
            {
                query = query.Where(r => r.StarCount <= svm.StarCount);
            }

            if (svm.UpdatedAfter != null)
            {
                query = query.Where(r => r.LastUpdate >= svm.UpdatedAfter);
            }

            List<Repository> SelectedRepositories = query.Include(r => r.Language).ToList();

            //Populate the view bag with a count of all repositories
            ViewBag.AllRepositories = _context.Repositories.Count();

            //Populate the view bag with a count of selected repositories
            ViewBag.SelectedRepositories = SelectedRepositories.Count;
            return View("Index", SelectedRepositories.OrderByDescending(r => r.StarCount));
        }
    }
}


