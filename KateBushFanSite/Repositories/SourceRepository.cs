using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KateBushFanSite.Models;
using Microsoft.EntityFrameworkCore;

namespace KateBushFanSite.Repositories
{
    public class SourceRepository : ISourceRepository
    {
        private AppDbContext context;

        public IQueryable<PrintSource> PrintSources => context.PrintSources;
        public IQueryable<WebSource> WebSources => context.WebSources;

        public SourceRepository(AppDbContext appContext)
        {
            context = appContext;
        }

        /// <summary>
        /// Adds a print source to the list
        /// </summary>
        /// <param name="printSource">form-generated Source object</param>
        public void AddPrintSource(PrintSource printSource)
        {
            context.PrintSources.Add(printSource);
            context.SaveChanges();
        }

        /// <summary>
        /// Adds a web source to the list
        /// </summary>
        /// <param name="webSource">form-generated Source object</param>
        public void AddWebSource(WebSource webSource)
        {
            context.WebSources.Add(webSource);
            context.SaveChanges();
        }
    }
}
