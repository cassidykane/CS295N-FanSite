using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using KateBushFanSite.Models;
using System.Web;

namespace KateBushFanSite.Controllers
{
    /// <summary>
    /// Controls the logic for displaying and submitting stories
    /// </summary>
    public class StoryController : Controller
    {
        /// <summary>
        /// Gets a list of stories from the the Repository
        /// Sorts the stories by most recent date
        /// Displays the story view populated with the sorted list
        /// </summary>
        /// <returns>story/index view with the sorted list</returns>
        public ViewResult Index()
        {
            List<Story> stories = Repository.Stories;
            stories.Sort((s1, s2) => DateTime.Compare(s1.Date, s2.Date));
            stories.Reverse();
            return View(stories);
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
        /// Retrieves the form inputs and assigns them to corresponding properties of a Story object
        /// Adds the Story object to the repository
        /// </summary>
        /// <param name="story">an instance of the Story class with form-generated properties</param>
        /// <returns></returns>
        [HttpPost]
        public RedirectToActionResult SubmitStory(string title, string date, string userStory)
        {
            Story story = new Story()
            {
                Title = title,
                Date = DateTime.Parse(date),
                UserStory = userStory
            };
            Repository.AddStory(story);
            return RedirectToAction("Index");
        }

        public IActionResult ReviewStory(string title)
        {
            ViewBag.avgRating = (Repository.GetStoryByTitle(title).Ratings.Count > 0) ? Repository.GetStoryByTitle(title).AverageRating() : 0;
            return View("ReviewStory", HttpUtility.HtmlDecode(title));
        }

        [HttpPost]
        public RedirectToActionResult ReviewStory(string title, string rating, string comment)
        {
            Story story = Repository.GetStoryByTitle(title);
            if (rating != null)
                story.Ratings.Add(Int32.Parse(rating));
            if (comment != null)
                story.Comments.Add(comment);
            /return RedirectToAction("Index");
        }
    }
}
