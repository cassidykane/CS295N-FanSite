using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KateBushFanSite.Models
{
    /// <summary>
    /// Properties for print sources
    /// </summary>
    public class WebSource : Source
    {
        public int WebSourceID { get; set; }

        [StringLength(100, MinimumLength = 4)]
        [Required(ErrorMessage = "Please enter a URL")]
        public string Url { get; set; }
    }
}
