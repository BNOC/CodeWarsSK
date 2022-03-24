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

        [Test]
        public void If_Move_Requested_Is_Legal__ReturnTrue()
        {
            var moveRequested = 0;
            var player = 1;
            Assert.That(_gs.RequestMove(moveRequested, player), Is.True);
        }

        [Test]
        public void If_Move_Requested_Is_Illegal__ReturnFalse()
        {
            var moveRequested = 5;
            var player = 2;
            Assert.That(_gs.RequestMove(moveRequested, player), Is.False);
        }
    }
}
