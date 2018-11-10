using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KateBushFanSite.Models;

namespace KateBushFanSite.Repositories
{
    /// <summary>
    /// Stores sources and stories submitted by the user
    /// </summary>
    public class StoryRepository : IStoryRepository
    {
        private AppDbContext context;

        /// <summary>
        /// gets the list of submitted stories
        /// </summary>
        public List<Story> Stories { get { return context.Stories.ToList(); } }

        public StoryRepository(AppDbContext appContext)
        {
            context = appContext;
        }

        /// <summary>
        /// Returns a the story with the specified title
        /// </summary>
        /// <param name="title">the story's title</param>
        /// <returns>corresponding Story object</returns>
        public Story GetStoryByTitle(string title)
        {
            Story story = context.Stories.First(s => s.Title == title);
            return story;
        }

        /// <summary>
        /// Adds a story to the list
        /// </summary>
        /// <param name="story">form-generated Story object</param>
        public void AddStory(Story story)
        {
            context.Stories.Add(story);
            context.SaveChanges();
        }
    }
}
