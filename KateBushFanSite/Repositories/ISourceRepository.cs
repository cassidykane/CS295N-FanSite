using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KateBushFanSite.Models;

namespace KateBushFanSite.Repositories
{
    public interface ISourceRepository
    {
        IQueryable<PrintSource> PrintSources { get; }
        IQueryable<WebSource> WebSources { get; }

        void AddPrintSource(PrintSource printSource);
        void AddWebSource(WebSource webSource);
    }
}
