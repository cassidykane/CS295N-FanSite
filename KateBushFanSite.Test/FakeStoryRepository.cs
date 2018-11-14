using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KateBushFanSite.Models;
using KateBushFanSite.Repositories;

namespace KateBushFanSite.Test
{
    /// <summary>
    /// Stores sources and stories submitted by the user
    /// </summary>
    public class FakeStoryRepository : IStoryRepository
    {
        private List<Story> stories = new List<Story>();

        public FakeStoryRepository()
        {
            AddTestData();
        }
        /// <summary>
        /// gets the list of submitted stories
        /// </summary>
        public List<Story> Stories { get { return stories; } }

        /// <summary>
        /// Returns a the story with the specified title
        /// </summary>
        /// <param name="title">the story's title</param>
        /// <returns>corresponding Story object</returns>
        public Story GetStoryByTitle(string title)
        {
            Story story = stories.Find(s => s.Title == title);
            return story;
        }

        /// <summary>
        /// Adds a story to the list
        /// </summary>
        /// <param name="story">form-generated Story object</param>
        public void AddStory(Story story) => stories.Add(story);

        void AddTestData()
        {
            Story story = new Story()
            {
                Title = "Story 1",
                Date = new DateTime(18, 1, 21),
                StoryText = "this is a test story"
            };
            stories.Add(story);
        }

        public void AddRating(Story story, Rating rating)
        {
            throw new NotImplementedException();
        }

        public void AddComment(Story story, Comment comment)
        {
            throw new NotImplementedException();
        }
    }
}
