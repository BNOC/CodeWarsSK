using CodeWars.TTT;
using NUnit.Framework;
using System.Collections.Generic;

namespace CodeWarsUnitTests.TTT
{
    [TestFixture]
    public class CheckGameStateInPlayTest
    {
        private GameService _gs;

        [SetUp]
        public void SetUp()
        {
            _gs = new GameService();
        }
        [DatapointSource]
        public List<string>[] boards = new List<string>[] {
            new() { "X", "1", "2", "O", "4", "X", "X", "X", "O" },
            new() { "X", "1", "O", "O", "X", "X", "X", "7", "8" },
            new() { "0", "O", "2", "X", "4", "5", "O", "X", "O" }
        };

        [Theory]
        public void If_Game_Is_In_Play__ReturnTrue(List<string> board)
        {
            Assert.That(_gs.CheckGameState(board), Is.EqualTo(GameState.InPlay));
        }
    }
}
