using CodeWars;
using Xunit;

namespace CodeWarsUnitTests
{
    public class LikesCounterTests
    {
        [Fact]
        public void BaseTest()
        {
            Assert.Equal("No one likes this", LikesCounterService.Likes(new string[0]));
            Assert.Equal("Sean likes this", LikesCounterService.Likes(new string[] { "Sean" }));
            Assert.Equal("Sean and Alex like this", LikesCounterService.Likes(new string[] { "Sean", "Alex" }));
            Assert.Equal("Sean, Alex and 2 others like this", LikesCounterService.Likes(new string[] { "Sean", "Alex", "Mark", "Max" }));
        }
    }
}
