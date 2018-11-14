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
        private List<Comment> comments = new List<Comment>();
        private List<Rating> ratings = new List<Rating>();

        public int StoryID { get; set; }

        [Required(ErrorMessage = "Please enter a title")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Please enter a Date")]
        public DateTime Date { get; set; }

        [Required(ErrorMessage = "Please enter a Story")]
        public string StoryText { get; set; }

        public List<Comment> Comments { get; set; }

        public List<Rating> Ratings { get; set; }

        public double AverageRating()
        {
            List<int> ratingNumbers = new List<int>();
            foreach (Rating r in ratings)
                ratingNumbers.Add(r.RatingNumber);
            return ratingNumbers.Average();
        }
    }
}
