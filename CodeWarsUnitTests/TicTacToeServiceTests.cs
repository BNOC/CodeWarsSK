using CodeWars;
using System;
using System.Collections.Generic;
using Xunit;

namespace CodeWarsUnitTests
{
    public class TicTacToeServiceTests
    {
        private readonly TicTacToeService _tttService;

        public TicTacToeServiceTests()
        {
            _tttService = new TicTacToeService();
        }

        [Theory]
        [InlineData(new object[] { new string[] { "O", "O", "O", "X", "X", "O", "X", "X", "O" } })]
        [InlineData(new object[] { new string[] { "X", "X", "X", "O", "O", "X", "O", "O", "X" } })]
        public void If_There_Is_A_Winner_On_Line_One_ReturnTrue(string[] value)
        {
            var result = _tttService.CheckForWinnerOnGivenLine(value, 1, 3);

            Assert.True(result, $"{value} should be a winner on line 1");
        }

        [Fact]
        public void If_Grid_Positions_For_A_Given_Line_Are_As_Expected_ReturnTrue()
        {
            List<int> expectedGridPositionsForLine = new List<int>() { 0, 1, 2, 3 };
            Assert.Equal(expectedGridPositionsForLine, _tttService.GetListOfPositionsForAGivenLine(1, 4));
        }

        [Fact]
        public void If_Grid_Positions_For_A_Given_Line_Are_Not_As_Expected_ReturnFalse()
        {
            List<int> expectedGridPositionsForLine = new List<int>() { 0, 1, 2, 5 };
            Assert.NotEqual(expectedGridPositionsForLine, _tttService.GetListOfPositionsForAGivenLine(1, 4));
        }
    }
}
