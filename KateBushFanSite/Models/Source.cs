using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KateBushFanSite.Models
{
    public abstract class Source
    {
        [StringLength(100, MinimumLength = 2)]
        [Required(ErrorMessage = "Please enter a title")]
        public string Title { get; set; }
    }
}
