using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public class Program
    {
        // Run Tests
		public static void Main(string[] args)
        {
            List<KeyValuePair<int, int>> movesMade = new();

            // Create grid
            Console.WriteLine("How big do you want the grid?");
            int gridSize = int.Parse(Console.ReadLine());
            TicTacToeService.CreateBoard(gridSize, movesMade);

            // Could change this to loop until there's a winner
            for (int move = 1; move < (gridSize * gridSize) + 1; move++)
            {
                // Read input
                int playerMove = int.Parse(Console.ReadLine());

                // Decide who's making the move, P1 = O, P2 = X
                int playerMakingMove;
                if (move % 2 == 0)
                    playerMakingMove = 2;
                else
                    playerMakingMove = 1;

                movesMade.Add(new KeyValuePair<int, int>(playerMakingMove, playerMove));

                // Could separate concern here - Make a move, display updated grid etc; 
                TicTacToeService.MakeAMove(gridSize, playerMakingMove, playerMove, movesMade);
            }
        }
	}
}
