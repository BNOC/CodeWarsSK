using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public class TicTacToeService
    {
        public static void MakeAMove(int gridSize, int playerJustMoved, int positionJustPlayed, List<KeyValuePair<int, int>> playerMoves)
        {
            // Create empty array of correct size for grid and default values to "";
            string[] movesArray = new string[gridSize * gridSize];
            for (int movesToAdd = 0; movesToAdd < gridSize * gridSize; movesToAdd++)
            {
                movesArray[movesToAdd] = "";
            }

            // Foreach move that's been made, change the array to match the players marks
            foreach (var pair in playerMoves)
            {
                int playerKey = pair.Key;

                string playerMark;
                if (playerKey == 1)
                    playerMark = "O";
                else
                    playerMark = "X";
                movesArray[pair.Value] = playerMark;
            }

            Console.WriteLine("Player {0} just played {1}", playerJustMoved, positionJustPlayed);

            // Post the new board to the console
            CreateBoard(gridSize, playerMoves);

            // Check for a winner after each move
            int linesThatCanWin = (gridSize * 2) + 2;
            int line = 1;
            while (line <= linesThatCanWin)
            {
                CheckForWinnerOnGivenLine(movesArray, line, gridSize);

                line++;
            }
        }

        public static void CreateBoard(int gridSize, List<KeyValuePair<int, int>> playerMoves)
        {
            var rowSize = gridSize;
            var rowItem = 0;

            CreateBoardRowBorders(gridSize);

            // Each Row
            for (int i = 0; i < gridSize; i++)
            {
                // Each column
                while (rowItem < rowSize)
                {
                    CreateBoardRow(rowItem, playerMoves);
                    rowItem++;
                }

                rowSize += gridSize;

                CreateBoardRowBorders(gridSize);
            }
        }

        public static void CreateBoardRowBorders(int gridSize)
        {
            Console.WriteLine("");
            for (int a = 0; a < gridSize; a++)
            {
                Console.Write("|------|", a);
            }
            Console.WriteLine("");
        }

        public static void CreateBoardRow(int rowItem, List<KeyValuePair<int, int>> playerMoves)
        {
            string playerMark = string.Empty;
            // Is there a move that matches this grid spot
            bool exists = playerMoves.Where(x => x.Value == rowItem).Any();
            int playerKey = playerMoves.Where(x => x.Value == rowItem).FirstOrDefault().Key;

            // Set players Mark
            if (playerKey == 1)
                playerMark = "O";
            else
                playerMark = "X";

            // Require extra spacing when under 10 - Would need extra spacing if we went over 100 etc also, but ignoring that.
            if (rowItem < 10)
            {
                // If one of the KeyValuePairs has the value matching this rowItem, set it to the players mark, else display standard grid spot             
                if (exists)
                    Console.Write("|  {0}   |", playerMark);
                else
                    Console.Write("|  {0}   |", rowItem);
            }
            else
            {
                if (exists)
                    Console.Write("|  {0}   |", playerMark);
                else
                    Console.Write("|  {0}  |", rowItem);
            }
        }
        
        public static bool CheckForWinnerOnGivenLine(string[] result, int line, int gridSize)
        {
            // Get array of positions for the line we're checking
            var linePositions = GetListOfPositionsForAGivenLine(line, gridSize);
            List<string> resultsToCheck = new();

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

            Console.WriteLine("We have a winner, congratulations.");

            return true;
        }

        public static List<int> GetListOfPositionsForAGivenLine(int lineNum, int gridSize)
        {
            List<int> allPositionsForGrid = new();
            List<int> listOfPositionsForLine = new();

            // Add grid positions to list
            for (int i = 0; i < gridSize * gridSize; i++)
            {
                allPositionsForGrid.Add(i);
            }

            // Are we looking at a diagonal line
            if (lineNum > gridSize * 2)
            {
                // First diagonal, top left to bottom right.
                if (lineNum == (gridSize * 2) + 1)
                {
                    // Grid end
                    int lineEnd = allPositionsForGrid.Last();

                    // Add positions of diagonal
                    for (int i = 0; i < gridSize; i++)
                    {
                        listOfPositionsForLine.Add(lineEnd);
                        lineEnd -= (gridSize + 1);
                    }
                }
                // Second diagonal, top right to bottom left.
                else if (lineNum == (gridSize * 2) + 2)
                {
                    // Get bottom left position
                    int lineEnd = allPositionsForGrid.Last() - (gridSize - 1);

                    // Added positions of diagonal
                    for (int i = 0; i < gridSize; i++)
                    {
                        listOfPositionsForLine.Add(lineEnd);
                        lineEnd -= (gridSize - 1);
                    }
                }
            }
            else if (lineNum > gridSize && lineNum <= gridSize * 2)
            {
                // Vertical Lines
                // Get bottom position
                int difference = lineNum - gridSize;
                int lineEnd = (allPositionsForGrid.Last() - gridSize) + difference;

                for (int i = 0; i < gridSize; i++)
                {
                    listOfPositionsForLine.Add(lineEnd);
                    lineEnd -= (gridSize);
                }
            }
            else
            {
                // Calculate the end position of the given line
                int lineEnd = (gridSize * lineNum) - 1;

                // Add the positions for that line into the list
                for (int i = 0; i < gridSize; i++)
                {
                    listOfPositionsForLine.Add(lineEnd - i);
                }
            }

            // Reverse the array
            listOfPositionsForLine.Reverse();

            return listOfPositionsForLine;
        }
    }
}
