using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace KateBushFanSite.Models
{
    /// <summary>
    /// Properties for submitted stories
    /// </summary>
    public class Story
    {
        //private List<StoryReview> reviews = new List<StoryReview>();
        private List<string> comments = new List<string>();
        private List<int> ratings = new List<int>();
        //[Required(ErrorMessage = "Please enter a title")]
        public string Title { get; set; }

        //[Required(ErrorMessage = "Please enter a Date")]
        public DateTime Date { get; set; }

        //[Required(ErrorMessage = "Please enter a Story")]
        public string UserStory { get; set; }

        public List<int> Ratings { get { return ratings; } }

        public List<string> Comments { get { return comments; } }

        /*public List<int> Ratings
        {
            get
            {
                foreach (StoryReview r in reviews)
                {
                    if (r.Rating != null)
                        ratings.Add((int)r.Rating);
                }
                return ratings;
            }
        }
        */
        public double AverageRating() => ratings.Average();
    }
}
