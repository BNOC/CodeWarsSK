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
        public void If_There_Is_A_Winner_On_Line_One_Horizontal_ReturnTrue(string[] value)
        {
            var result = TicTacToeService.CheckForWinnerOnGivenLine(value, 1, 3);

            Assert.True(result, $"{value} should be a winner on line 1");
        }

        [Theory]
        [InlineData(new object[] { new string[] { "O", "O", "X", "O", "X", "X", "O", "X", "O" } })]
        [InlineData(new object[] { new string[] { "X", "O", "O", "X", "O", "X", "X", "X", "O" } })]
        public void If_There_Is_A_Winner_On_Line_Four_Vertical_ReturnTrue(string[] value)
        {
            var result = TicTacToeService.CheckForWinnerOnGivenLine(value, 4, 3);

            Assert.True(result, $"{value} should be a winner on line 1");
        }

        [Theory]
        [InlineData(new object[] { new string[] { "O", "O", "X", "X", "O", "O", "X", "X", "O" } })]
        [InlineData(new object[] { new string[] { "X", "O", "X", "O", "X", "X", "O", "O", "X" } })]
        public void If_There_Is_A_Winner_On_Line_Seven_Diagonal_ReturnTrue(string[] value)
        {
            var result = TicTacToeService.CheckForWinnerOnGivenLine(value, 7, 3);

            Assert.True(result, $"{value} should be a winner on line 7");
        }

        [Fact]
        public void If_Grid_Positions_For_A_Given_Line_Are_As_Expected_ReturnTrue()
        {
            List<int> expectedGridPositionsForLine = new List<int>() { 0, 1, 2, 3 };
            Assert.Equal(expectedGridPositionsForLine, TicTacToeService.GetListOfPositionsForAGivenLine(1, 4));
        }

        [Fact]
        public void If_Grid_Positions_For_A_Given_Line_Are_Not_As_Expected_ReturnFalse()
        {
            List<int> expectedGridPositionsForLine = new List<int>() { 0, 1, 2, 5 };
            Assert.NotEqual(expectedGridPositionsForLine, TicTacToeService.GetListOfPositionsForAGivenLine(1, 4));
        }

        [Fact]
        public void If_Grid_Positions_For_Diagonal_To_Bottom_Right_As_Expected_ReturnTrue()
        {
            List<int> expectedGridPositionsForLine = new List<int>() { 0, 5, 10, 15 };
            Assert.Equal(expectedGridPositionsForLine, TicTacToeService.GetListOfPositionsForAGivenLine(9, 4));
        }

        [Fact]
        public void If_Grid_Positions_For_Diagonal_To_Bottom_Left_As_Expected_ReturnTrue()
        {
            List<int> expectedGridPositionsForLine = new List<int>() { 3, 6, 9, 12 };
            Assert.Equal(expectedGridPositionsForLine, TicTacToeService.GetListOfPositionsForAGivenLine(10, 4));
        }

        [Fact]
        public void If_Grid_Positions_For_Diagonal_To_Bottom_Left_On_Bigger_Grid_As_Expected_ReturnTrue()
        {
            List<int> expectedGridPositionsForLine = new List<int>() { 5, 10, 15, 20, 25, 30 };
            Assert.Equal(expectedGridPositionsForLine, TicTacToeService.GetListOfPositionsForAGivenLine(14, 6));
        }

        [Fact]
        public void If_Grid_Positions_For_Diagonal_To_Bottom_Left_On_Bigger_Grid_Not_As_Expected_ReturnFalse()
        {
            // 0 1 2
            // 3 4 5
            // 6 7 8
            List<int> expectedGridPositionsForLine = new List<int>() { 2, 4, 5 };
            Assert.NotEqual(expectedGridPositionsForLine, TicTacToeService.GetListOfPositionsForAGivenLine(8, 3));
        }
    }
}
