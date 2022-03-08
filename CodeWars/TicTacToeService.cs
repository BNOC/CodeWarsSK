using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public class TicTacToeService
    {
        public int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        public void SetupGrid(int gridSize)
        {
            for (int row = 0; row < gridSize; row++)
            {
                Console.WriteLine(" - - - ");
            }
        }

        // Board method which creats board
        private void Board()
        {
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[1], arr[2], arr[3]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[4], arr[5], arr[6]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[7], arr[8], arr[9]);
            Console.WriteLine("     |     |      ");
        }
        // Check for a winner on a specific line
        public bool CheckForWinnerOnGivenLine(string[] result, int line, int gridSize)
        {
            // Get array of positions for the line we're checking
            var linePositions = GetListOfPositionsForAGivenLine(line, gridSize);

            List<string> resultsToCheck = new List<string>();
            // Create a new list of results we need to check given the positions we fetched
            foreach (var position in linePositions)
            {
                resultsToCheck.Add(result[position]);
            }

            // If the line is not all the same mark, return false, else true
            if (!resultsToCheck.All(x => x == "X") && !resultsToCheck.All(x => x == "O"))
            {
                return false;
            }

            return true;
        }

        public List<int> GetListOfPositionsForAGivenLine(int lineNum, int gridSize)
        {
            List<int> positions = new List<int>();

            // Add grid positions to array
            for (var i = 0; i < gridSize * gridSize; i++)
            {
                positions.Add(i);
            }

            // Calculate the end position of the given line
            var lineEnd = (gridSize * lineNum) - 1;

            // Add the positions for that line into the linePositions Array
            List<int> linePositions = new();
            for (var i = 0; i < gridSize; i++)
            {
                linePositions.Add(lineEnd - i);
            }
            
            // Reverse the array
            linePositions.Reverse();

            return linePositions;

            // if lineNum is bigger than grid size, we're looking at vertical/diagonal, figure that out
        }
    }
}
