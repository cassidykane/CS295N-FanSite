using System;
using System.Collections.Generic;
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
        public string Url { get; set; }
    }
}
