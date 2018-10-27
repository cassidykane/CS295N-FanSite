using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KateBushFanSite.Models
{
    /// <summary>
    /// Stores sources and stories submitted by the user
    /// </summary>
    public static class Repository
    {
        private static List<Story> stories = new List<Story>();
        private static List<PrintSource> printSources = new List<PrintSource>
        {
            new PrintSource()
            {
                Author = "Author B",
                Title = "this is a model-generated print source"
            },
            new PrintSource()
            {
                Author = "Author C",
                Title = "this is another model-generated print source"
            },
            new PrintSource()
            {
                Author = "Author A",
                Title = "this is yet another model-generated print source"
            }
        };
        private static List<WebSource> webSources = new List<WebSource>
        {
            new WebSource()
            {
                Url = "#",
                Title = "this is a model-generated link"
            },
            new WebSource()
            {
                Url = "#",
                Title = "this is another model-generated link"
            }
        };

        /// <summary>
        /// gets the list of submitted stories
        /// </summary>
        public static List<Story> Stories { get { return stories; } }
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
