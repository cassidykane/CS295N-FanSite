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
        private static List<Source> sources = new List<Source>();

        /// <summary>
        /// gets the list of submitted stories
        /// </summary>
        public static IEnumerable<Story> Stories => stories;
        /// <summary>
        /// gets the list of submitted sources
        /// </summary>
        public static IEnumerable<Source> Sources => sources;

        /// <summary>
        /// Adds a story to the list
        /// </summary>
        /// <param name="story">form-generated Story object</param>
        public static void AddStory(Story story) => stories.Add(story);
        /// <summary>
        /// Adds a source to the list
        /// </summary>
        /// <param name="source">form-generated Source object</param>
        public static void AddSource(Source source) => sources.Add(source);
    }
}
