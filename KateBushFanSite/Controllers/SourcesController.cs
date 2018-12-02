using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using KateBushFanSite.Models;
using KateBushFanSite.Repositories;
using System.Web;

namespace KateBushFanSite.Controllers
{
    public class SourcesController : Controller
    {
        ISourceRepository sourceRepo;
        public SourcesController(ISourceRepository repo)
        {
            sourceRepo = repo;
        }
        /// <summary>
        /// Retrieves web and print sources from the repository
        /// Sorts the print sources alphabetically by the first author's last name
        /// Sorts the web sources alphabetically by title
        /// Stores both of the sorted lists in a list of their base type (Source)
        /// </summary>
        /// <returns>the Source/Index with the Source list</returns>
        public IActionResult Index()
        {
            List<PrintSource> printSources = sourceRepo.PrintSources.ToList();
            List<WebSource> webSources = sourceRepo.WebSources.ToList();
            List<Source> sources = new List<Source>();
            printSources.Sort((p1, p2) => string.Compare(p1.AuthorLastName, p2.AuthorLastName, StringComparison.Ordinal));
            webSources.Sort((w1, w2) => string.Compare(w1.Title, w2.Title, StringComparison.Ordinal));
            sources.AddRange(printSources);
            sources.AddRange(webSources);
            return View(sources);
        }

        [HttpPost]
        public IActionResult Index(string author)
        {
            List<Source> printSources = (from ps in sourceRepo.PrintSources
                                   where ps.Author.ToLower() == author.ToLower()
                                   select ps).ToList<Source>();
            return View(printSources);
        }

        /// <summary>
        /// Displays the view for the print source submission form
        /// </summary>
        /// <returns>sources/submitprintsource.cshtml view</returns>
        public ViewResult SubmitPrintSource()
        {
            return View();
        }

        /// <summary>
        /// Retrieves the print source form inputs and assigns them to corresponding properties of a Story object
        /// Adds the Story object to the repository
        /// </summary>
        /// <param name="title">user-submitted title</param>
        /// /// <param name="author">user-submitted author name</param>
        /// <returns>the sources/index.cshtml page</returns>
        [HttpPost]
        public RedirectToActionResult SubmitPrintSource(PrintSource ps)
        {
            if (ModelState.IsValid)
            {
                /*
                PrintSource ps = new PrintSource()
                {
                    Title = title,
                    Author = author
                };
                */
                sourceRepo.AddPrintSource(ps);
            }
            return RedirectToAction("Index");
        }

        /// <summary>
        /// Displays the view for the web source submission form
        /// </summary>
        /// <returns>sources/submitwebsource.cshtml view</returns>
        public ViewResult SubmitWebSource()
        {
            return View();
        }

        /// <summary>
        /// Retrieves the web source form inputs and assigns them to corresponding properties of a Story object
        /// Adds the Story object to the repository
        /// </summary>
        /// <param name="title">user-submitted title</param>
        /// /// <param name="url">user-submitted url</param>
        /// <returns>the sources/index.cshtml page</returns>
        [HttpPost]
        public RedirectToActionResult SubmitWebSource(WebSource ws)
        {
            if (ModelState.IsValid)
            {
                /*
                WebSource ws = new WebSource()
                {
                    Title = title,
                    Url = url,
                };
                */
                sourceRepo.AddWebSource(ws);
            }
            return RedirectToAction("Index");
        }
    }
}