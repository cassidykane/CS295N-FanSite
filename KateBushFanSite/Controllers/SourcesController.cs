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
        public SourcesController()
        {
            Repository.AddSource(new Source() {
                Type = "print",
                PrintAuthor = "author name",
                PrintTitle = "this is a model-generated print source"
            });
            Repository.AddSource(new Source()
            {
                Type = "print",
                PrintAuthor = "other author name",
                PrintTitle = "this is ANOTHER model-generated print source"
            });
            Repository.AddSource(new Source()
            {
                Type = "link",
                LinkHref = "#",
                LinkTitle = "this is a model-generated link"
            });
            Repository.AddSource(new Source()
            {
                Type = "link",
                LinkHref = "#",
                LinkTitle = "this is ANOTHER model-generated link"
            });
        }
        /*
        public IActionResult Index()
        {
            return View();
        }
        */
        public ViewResult Index()
        {
            return View(Repository.Sources);
        }

    }
}