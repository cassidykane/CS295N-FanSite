using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KateBushFanSite.Models;

namespace KateBushFanSite.Repositories
{
    public interface IStoryRepository
    {
        /// <summary>
        /// gets/sets the list of submitted stories
        /// </summary>
        IQueryable<Story> Stories { get; }

        /// <summary>
        /// Returns a the story with the specified title
        /// </summary>
        /// <param name="title">the story's title</param>
        /// <returns>corresponding Story object</returns>
        Story GetStoryByTitle(string title);

        void AddStory(Story story);

        void AddRating(Story story, Rating rating);

        void AddComment(Story story, Comment comment);
    }
}
