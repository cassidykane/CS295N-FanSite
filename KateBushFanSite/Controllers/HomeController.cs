using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using KateBushFanSite.Models;

namespace KateBushFanSite.Controllers
{
    /// <summary>
    /// Controls the logic for the site's landing page
    /// </summary>
    public class HomeController : Controller
    {
        /// <summary>
        /// Displays the Home View
        /// </summary>
        /// <returns>Home/Index.cshtml view</returns>
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Displays the History View
        /// </summary>
        /// <returns>Home/History.cshtml view</returns>
        public IActionResult History()
        {
            return View();
        }

        /*
        public IActionResult ShowStories()
        {
            return View(Stories.Stories);
        }
        */
    }
}
