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
    /// <summary>
    /// Controls the logic for displaying and submitting stories
    /// </summary>
    public class StoryController : Controller
    {
        IStoryRepository storyRepo;
        public StoryController(IStoryRepository repo)
        {
            storyRepo = repo;
        }
        /// <summary>
        /// Gets a list of stories from the the Repository
        /// Sorts the stories by most recent date
        /// Displays the story view populated with the sorted list
        /// </summary>
        /// <returns>story/index view with the sorted list</returns>
        public ViewResult Index()
        {
            List<Story> stories = storyRepo.Stories;
            if (stories == null)
                return View("SubmitStory");
            else if (stories.Count == 1)
                return View(stories);
            else
            {
                SortStories(stories);
                return View(stories);
            }
        }

        public void SortStories(List<Story> stories)
        {
            stories.Sort((s1, s2) => DateTime.Compare(s1.Date, s2.Date));
            stories.Reverse();
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
        /// <param name="title">user-submitted title</param>
        /// /// <param name="date">user-submitted date</param>
        /// /// <param name="userStory">user-submitted story</param>
        /// <returns>the story/index.cshtml page</returns>
        [HttpPost]
        public RedirectToActionResult SubmitStory(string title, string date, string userStory)
        {
            Story story = new Story()
            {
                Title = title,
                Date = DateTime.Parse(date),
                StoryText = userStory
            };
            storyRepo.AddStory(story);
            return RedirectToAction("Index");
        }

        public IActionResult ReviewStory(string title)
        {
            ViewBag.avgRating = (storyRepo.GetStoryByTitle(title).Ratings != null) ? storyRepo.GetStoryByTitle(title).AverageRating() : 0;
            //ViewBag.avgRating = storyRepo.GetStoryByTitle(title).AverageRating();
            return View("ReviewStory", HttpUtility.HtmlDecode(title));
        }

        [HttpPost]
        public RedirectToActionResult ReviewStory(string title, string rating, string comment)
        {
            Story story = storyRepo.GetStoryByTitle(title);
            if (rating != null)
                storyRepo.AddRating(story, new Rating() { RatingNumber = int.Parse(rating) }); 
            if (comment != null)
                storyRepo.AddComment(story, new Comment() { CommentText = comment});
            return RedirectToAction("Index");
        }
    }
}
