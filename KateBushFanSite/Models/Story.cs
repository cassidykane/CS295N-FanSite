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
        //[Required(ErrorMessage = "Please enter a title")]
        public string Title { get; set; }

        //[Required(ErrorMessage = "Please enter a Date")]
        public DateTime Date { get; set; }

        //[Required(ErrorMessage = "Please enter a Story")]
        public string UserStory { get; set; }

        public int Rating { get; set; }

        public string Comment { get; set; }
    }
}
