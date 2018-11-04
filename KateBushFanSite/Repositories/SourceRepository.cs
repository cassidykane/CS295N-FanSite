using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KateBushFanSite.Models;

namespace KateBushFanSite.Repositories
{
    public class SourceRepository : ISourceRepository
    {
        private List<PrintSource> printSources = new List<PrintSource>();
        private List<WebSource> webSources = new List<WebSource>();

        /// <summary>
        /// gets the list of submitted print sources
        /// </summary>
        public List<PrintSource> PrintSources => printSources;

        /// <summary>
        /// gets the list of submitted web sources
        /// </summary>
        public List<WebSource> WebSources => webSources;

        /// <summary>
        /// Adds a print source to the list
        /// </summary>
        /// <param name="printSource">form-generated Source object</param>
        public void AddPrintSource(PrintSource printSource) => printSources.Add(printSource);

        /// <summary>
        /// Adds a web source to the list
        /// </summary>
        /// <param name="webSource">form-generated Source object</param>
        public void AddWebSource(WebSource webSource) => webSources.Add(webSource);
    }
}
