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
    public class PrintSource : Source
    {
        public int PrintSourceID { get; set; }

        [StringLength(30, MinimumLength = 2)]
        [Required(ErrorMessage = "Please enter a name")]
        public string Author { get; set; }

        public string AuthorLastName
        {
            get
            {
                string lastName = this.Author;
                foreach (char c in lastName)
                {
                    lastName.Remove(lastName.IndexOf(c));
                    if (c.ToString() == " ")
                        break;
                }
                return lastName;
            }
        }
    }
}
