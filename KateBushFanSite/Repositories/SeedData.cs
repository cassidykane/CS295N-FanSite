using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using KateBushFanSite.Models;

namespace KateBushFanSite.Repositories
{
    public class SeedData
    {
        public static void Seed(IApplicationBuilder app)
        {
            AppDbContext context = app.ApplicationServices.GetRequiredService<AppDbContext>();
            context.Database.EnsureCreated();

            if (!context.Stories.Any())
            {
                Story story1 = new Story
                {
                    Title = "Seed Story 1",
                    Date = new DateTime(1997, 1, 1),
                    StoryText = "This is the first story from the seed data"
                };
                context.Stories.Add(story1);
                story1.Comments.Add(new Comment { CommentText = "what a fascinating story" });

                Story story2 = new Story
                {
                    Title = "Seed Story 2",
                    Date = new DateTime(1998, 1, 1),
                    StoryText = "This is the second story from the seed data"
                };
                context.Stories.Add(story2);
                story2.Ratings.Add(new Rating { RatingNumber = 5 });

                context.SaveChanges();
            }

            if (!context.PrintSources.Any())
            {
                PrintSource ps = new PrintSource
                {
                    Title = "Book 3",
                    Author = "Author C"
                };
                context.PrintSources.Add(ps);

                ps = new PrintSource
                {
                    Title = "Book 4",
                    Author = "Author C"
                };
                context.PrintSources.Add(ps);

                ps = new PrintSource
                {
                    Title = "Book 2",
                    Author = "Author B"
                };
                context.PrintSources.Add(ps);

                ps = new PrintSource
                {
                    Title = "Book 1",
                    Author = "Author A"
                };
                context.PrintSources.Add(ps);

                context.SaveChanges();
            }

            if (!context.PrintSources.Any())
            {
                WebSource ws = new WebSource
                {
                    Title = "Wikipedia Entry",
                    Url = "https://en.wikipedia.org/wiki/Kate_Bush"
                };
                context.WebSources.Add(ws);

                ws = new WebSource
                {
                    Title = "Official Site",
                    Url = "http://katebush.com/"
                };
                context.WebSources.Add(ws);

                new WebSource
                {
                    Title = "AllMusic Bio",
                    Url = "https://www.allmusic.com/artist/kate-bush-mn0000855423"
                };
                context.WebSources.Add(ws);

                context.SaveChanges();
            }
        }
    }
}
