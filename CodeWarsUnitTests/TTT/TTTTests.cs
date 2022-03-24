using CodeWars.TTT;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsUnitTests.TTT
{
    [TestFixture]
    public class TTTTests
    {
        private GameService _gs;

        [SetUp]
        public void SetUp()
        {
            _gs = new GameService();
        }

        [Test]
        public void If_Tokens_Are_Valid__ReturnTrue()
        {
            var firstToken = _gs.GetToken(1);
            var secondToken = _gs.GetToken(2);

            Assert.AreEqual(firstToken, "X");
            Assert.AreEqual(secondToken, "O");
        }

        [Test]
        public void If_Board_Has_Correct_Count__ReturnTrue()
        {
            var board = _gs.GetCurrentBoard();
            List<string> expected = new() { "0", "1", "2", "3", "4", "5", "6", "7", "8" };

            Assert.AreEqual(expected.Count, board.Count);
        }

    }
}
