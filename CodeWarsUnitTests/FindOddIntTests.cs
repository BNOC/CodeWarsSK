using CodeWars;
using NUnit.Framework;

namespace CodeWarsUnitTests
{
    [TestFixture]
    public class FindOddIntTests
    {
        [Test]
        public void BaseTest()
        {
            Assert.AreEqual(5, FindOddInt.Find(new[] { 20, 1, -1, 2, -2, 3, 3, 5, 5, 1, 2, 4, 20, 4, -1, -2, 5 }));
        }

        [Test]
        public void TestBestAnswer()
        {
            Assert.AreEqual(5, FindOddInt.FindBestAnswer(new[] { 20, 1, -1, 2, -2, 3, 3, 5, 5, 1, 2, 4, 20, 4, -1, -2, 5 }));
        }

    }
}
