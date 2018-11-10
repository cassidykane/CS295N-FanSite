using KateBushFanSite.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KateBushFanSite.Repositories
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Story> Stories { get; set; }
        public DbSet<PrintSource> PrintSources { get; set; }
        public DbSet<WebSource> WebSources { get; set; }
    }
}
