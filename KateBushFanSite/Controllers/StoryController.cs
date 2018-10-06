using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using KateBushFanSite.Models;

namespace KateBushFanSite.Controllers
{
    public class StoryController : Controller
    {
        Story story;
        /*
        public StoryController()
        {
            story = new Story()
            {
                Title = "Sample",
                Date = DateTime.Now,
                UserStory = "This is a sample story created in the constructor"
            };
        }
        */
        public ViewResult Index()
        {
            return View(Repository.Stories);
        }


        [HttpGet]
        public ViewResult SubmitStory()
        {
            return View();
        }

        [HttpPost]
        public ViewResult SubmitStory(Story story)
        {
            story.Rating = 0;
            Repository.AddStory(story);
            return View();
        }

        /*
        [HttpPost]
        public RedirectToActionResult SubmitStory(string title, string date, string userStory)
        {
            story = new Story();
            story.Title = title;
            story.Date = DateTime.Parse(date);
            return RedirectToAction("Index");
        }
        */

    }
}
