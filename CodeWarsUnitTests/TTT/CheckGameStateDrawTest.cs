using CodeWars.TTT;
using NUnit.Framework;
using System.Collections.Generic;

namespace CodeWarsUnitTests.TTT
{
    [TestFixture]
    public class CheckGameStateDrawTest
    {
        private GameService _gs;

        [SetUp]
        public void SetUp()
        {
            _gs = new GameService();
        }

        [DatapointSource]
        public List<string>[] boards = new List<string>[] {
            new() { "X", "O", "X", "O", "O", "X", "X", "X", "O" },
            new() { "X", "O", "O", "O", "X", "X", "X", "X", "O" },
            new() { "X", "O", "X", "X", "X", "O", "O", "X", "O" }
        };

        [Theory]
        public void If_Game_Is_A_Draw__ReturnTrue(List<string> board)
        {
            Assert.That(_gs.CheckGameState(board), Is.EqualTo(GameState.Draw));
        }
    }
}
