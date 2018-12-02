using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KateBushFanSite.Models
{
    public class Comment
    {
        public int CommentID { get; set; }

        [StringLength(200)]
        public string CommentText { get; set; }
    }
}
