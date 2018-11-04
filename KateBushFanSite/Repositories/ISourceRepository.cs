using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KateBushFanSite.Models;

namespace KateBushFanSite.Repositories
{
    interface ISourceRepository
    {
        List<PrintSource> PrintSources { get; }
        List<WebSource> WebSources { get; }

        void AddPrintSource(PrintSource printSource);
        void AddWebSource(WebSource webSource);
    }
}
