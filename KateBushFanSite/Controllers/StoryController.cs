using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using KateBushFanSite.Models;

namespace KateBushFanSite.Controllers
{
    /// <summary>
    /// Controls the logic for displaying and submitting stories
    /// </summary>
    public class StoryController : Controller
    {
        /// <summary>
        /// Displays the story view populated with stories from the repository
        /// </summary>
        /// <returns>story/index.cshtml view, Story objects</returns>
        public ViewResult Index()
        {
            return View(Repository.Stories);
        }

        /// <summary>
        /// Displays the view for the story-submission form
        /// </summary>
        /// <returns>story/submitstory.cshtml view</returns>
        public ViewResult SubmitStory()
        {
            return View();
        }

        /// <summary>
        /// Sets the default rating of the story to zero
        /// Retrieves the form inputs and assigns them to corresponding properties of a Story object
        /// Adds the Story object to the repository
        /// </summary>
        /// <param name="story">an instance of the Story class with form-generated properties</param>
        /// <returns></returns>
        [HttpPost]
        public RedirectToActionResult SubmitStory(Story story)
        {
            story.Rating = 0;
            Repository.AddStory(story);
            return RedirectToAction("Index");
        }
    }
}
