using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KateBushFanSite.Models
{
    /// <summary>
    /// Stores sources and stories submitted by the user
    /// </summary>
    public class Repository
    {
        private static List<Story> stories = new List<Story>();
        private static List<PrintSource> printSources = new List<PrintSource>();
        private static List<WebSource> webSources = new List<WebSource>();

        /// <summary>
        /// gets the list of submitted stories
        /// </summary>
        public static List<Story> Stories => stories;
        /// <summary>
        /// gets the list of submitted print sources
        /// </summary>
        public static List<PrintSource> PrintSources => printSources;

        /// <summary>
        /// gets the list of submitted web sources
        /// </summary>
        public static List<WebSource> WebSources => webSources;

        /// <summary>
        /// Returns a the story with the specified title
        /// </summary>
        /// <param name="title">the story's title</param>
        /// <returns>corresponding Story object</returns>
        public static Story GetStoryByTitle(string title)
        {
            Story story = stories.Find(s => s.Title == title);
            return story;
        }

        /// <summary>
        /// Adds a story to the list
        /// </summary>
        /// <param name="story">form-generated Story object</param>
        public static void AddStory(Story story) => stories.Add(story);

        /// <summary>
        /// Adds a print source to the list
        /// </summary>
        /// <param name="printSource">form-generated Source object</param>
        public static void AddPrintSource(PrintSource printSource) => printSources.Add(printSource);

        /// <summary>
        /// Adds a web source to the list
        /// </summary>
        /// <param name="webSource">form-generated Source object</param>
        public static void AddWebSource(WebSource webSource) => webSources.Add(webSource);
    }
}
