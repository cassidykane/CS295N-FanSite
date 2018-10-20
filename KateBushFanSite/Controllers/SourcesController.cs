using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using KateBushFanSite.Models;

namespace KateBushFanSite.Controllers
{
    public class SourcesController : Controller
    {
        /// <summary>
        /// Retrieves web and print sources from the repository
        /// Sorts the print sources alphabetically by the first author's last name
        /// Sorts the web sources alphabetically by title
        /// Stores both of the sorted lists in a list of their base type (Source)
        /// </summary>
        /// <returns>the Source/Index with the Source list</returns>
        public IActionResult Index()
        {
            List<PrintSource> printSources = Repository.PrintSources;
            List<WebSource> webSources = Repository.WebSources;
            List<Source> sources = new List<Source>();
            printSources.Sort((p1, p2) => string.Compare(p1.AuthorLastName, p2.AuthorLastName, StringComparison.Ordinal));
            webSources.Sort((w1, w2) => string.Compare(w1.Title, w2.Title, StringComparison.Ordinal));
            sources.AddRange(printSources);
            sources.AddRange(webSources);
            return View(sources);
        }

    }
}