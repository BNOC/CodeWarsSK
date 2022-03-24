using CodeWars;
using Xunit;

namespace CodeWarsUnitTests
{
    public class DetectPangramServiceTests
    {
        [Fact]
        public void BaseTests()
        {
            Assert.True(DetectPangramService.IsPangram("The quick brown fox jumps over the lazy dog"));
            Assert.False(DetectPangramService.IsPangram("The quick brown fox jumps over the bad dog"));
        }

        [Fact]
        public void BestAnswerTests()
        {
            Assert.True(DetectPangramService.IsPangramBestAnswer("The quick brown fox jumps over the lazy dog"));
            Assert.False(DetectPangramService.IsPangramBestAnswer("The quick brown fox jumps over the bad dog"));
        }
    }
}
