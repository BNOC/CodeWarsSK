using System;

namespace CodeWars
{
    public class Program
    {
        // Run Tests
		public static void Main(string[] args)
        {
			TicTacToeService ttt = new TicTacToeService();

            var gridSize = 3;
            ttt.SetupGrid(gridSize);

            for (var move = 1; move < (gridSize * gridSize) + 1; move++) 
            { 
                
            }
        }
	}
}
