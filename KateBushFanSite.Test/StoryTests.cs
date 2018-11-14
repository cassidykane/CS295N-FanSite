using System;
using Xunit;
using KateBushFanSite.Repositories;
using KateBushFanSite.Controllers;

namespace KateBushFanSite.Test
{
    public class StoryTests
    {

        [Fact]
        public void SubmitStoryTest()
        {
            var repo = new FakeStoryRepository();
            var storyController = new StoryController(repo);

            storyController.SubmitStory("title", "1/1/2001", "this is a story");

            Assert.Equal("title", repo.Stories[repo.Stories.Count -1].Title);
        }

        [Fact]
        public void SortStoriesTest()
        {
            var repo = new FakeStoryRepository();
            var storyController = new StoryController(repo);

            storyController.SubmitStory("title", "12/12/2018", "this is a story");
            storyController.SortStories(repo.Stories);

            Assert.Equal("title", repo.Stories[0].Title);
        }

        [Fact]
        public void ReviewStoryTest()
        {
            var repo = new FakeStoryRepository();
            var storyController = new StoryController(repo);

            storyController.ReviewStory("Story 1", "2", "wow");

            Assert.Equal(2, repo.Stories[0].Ratings[0].RatingNumber);
            Assert.Equal("wow", repo.Stories[0].Comments[0].CommentText);
        }
    }
}
