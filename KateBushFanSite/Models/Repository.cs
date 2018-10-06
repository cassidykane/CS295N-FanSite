using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KateBushFanSite.Models
{
    public class Repository
    {
        private static List<Story> stories = new List<Story>();
        private static List<Source> sources = new List<Source>();

        public static IEnumerable<Story> Stories => stories;
        public static IEnumerable<Source> Sources => sources;

        public static void AddStory(Story story) => stories.Add(story);
        public static void AddSource(Source source) => sources.Add(source);
    }
}
