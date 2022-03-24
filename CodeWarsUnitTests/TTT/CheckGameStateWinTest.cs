using CodeWars.TTT;
using NUnit.Framework;
using System.Collections.Generic;

namespace CodeWarsUnitTests.TTT
{
    [TestFixture]
    public class CheckGameStateWinTest
    {
        private GameService _gs;

        [SetUp]
        public void SetUp()
        {
            _gs = new GameService();
        }

        [DatapointSource]
        public List<string>[] boards = new List<string>[] {
            new() { "X", "X", "X", "O", "O", "X", "O", "X", "O" },
            new() { "X", "O", "O", "X", "X", "O", "X", "X", "O" },
            new() { "X", "O", "O", "X", "X", "O", "O", "X", "X" }
        };

        [Theory]
        public void If_Game_Is_A_Winner__ReturnTrue(List<string> board)
        {
            Assert.That(_gs.CheckGameState(board), Is.EqualTo(GameState.Winner));
        }
    }
}
