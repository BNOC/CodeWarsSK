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
    public class MovesMadeTest
    {
        private GameService _gs;

        [SetUp]
        public void SetUp()
        {
            _gs = new GameService();
        }

        [DatapointSource]
        public List<string>[] boards = new List<string>[] {
            new() { "0", "O", "X", "O", "O", "X", "X", "X", "O" },
            new() { "0", "O", "O", "O", "X", "X", "X", "X", "O" },
            new() { "0", "O", "X", "X", "X", "O", "O", "X", "O" }
        };

        [Test]
        public void If_Move_Requested_Is_Legal__ReturnTrue(List<string> board)
        {
            var moveRequested = 0;
            var player = 1;
            Assert.That(_gs.RequestMove(moveRequested, player, board), Is.True);
        }

        [Test]
        public void If_Move_Requested_Is_Illegal__ReturnFalse(List<string> board)
        {
            var moveRequested = 5;
            var player = 2;
            Assert.That(_gs.RequestMove(moveRequested, player, board), Is.False);
        }
    }
}
