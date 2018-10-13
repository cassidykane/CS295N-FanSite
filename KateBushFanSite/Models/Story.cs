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
        private List<StoryReview> reviews = new List<StoryReview>();
        private List<int> ratings = new List<int>();
        //[Required(ErrorMessage = "Please enter a title")]
        public string Title { get; set; }

        //[Required(ErrorMessage = "Please enter a Date")]
        public DateTime Date { get; set; }

        //[Required(ErrorMessage = "Please enter a Story")]
        public string UserStory { get; set; }

        public List<int> Ratings
        {
            get
            {
                foreach (StoryReview r in reviews)
                {
                    if (r.Rating > 0)
                        ratings.Add(r.Rating);
                }
                return ratings;
            }
        }

        public double AverageRating() => ratings.Average();

        public List<StoryReview> Reviews => reviews;
    }
}
