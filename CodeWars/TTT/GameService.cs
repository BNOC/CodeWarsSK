using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.TTT
{
    public class GameService
    {
        private List<string> _board;

        public GameService()
        {
            _board = new List<string>() { "0", "1", "2", "X", "X", "X", "X", "X", "X" };
        }

        public string GetToken(int player)
        {
            return player == 1 ? "X" : "O";
        }

        public void CurrentBoard (List<string> board)
        {
            _board = board;
        }

        public List<string> GetCurrentBoard()
        {
            return _board;
        }

        public void GetBaseBoard()
        {
            _board = new List<string>() { "0", "1", "2", "3", "4", "5", "6", "7", "8" };
        }



        public GameState CheckGameState(List<string> board)
        {
            if ((board[0] == board[1] && board[1] == board[2]) ||
                (board[3] == board[4] && board[4] == board[5]) ||
                (board[6] == board[7] && board[7] == board[8]) ||
                (board[0] == board[3] && board[3] == board[6]) ||
                (board[1] == board[4] && board[4] == board[7]) ||
                (board[2] == board[5] && board[5] == board[8]) ||
                (board[0] == board[4] && board[4] == board[8]) ||
                (board[2] == board[4] && board[4] == board[6]))
            {
                return GameState.Winner;
            }

            if (board[0] != "0" && board[1] != "1" && board[2] != "2" &&
                board[3] != "3" && board[4] != "4" && board[5] != "5" &&
                board[6] != "6" && board[7] != "1" && board[8] != "8")
            {
                return GameState.Draw;
            }
            else
            {
                return GameState.InPlay;
            }
        }

        public bool RequestMove(int move, int player)
        {
            //var board = GetCurrentBoard();
            if (_board[move] != "X" && _board[move] != "O")
            {
                _board[move] = player == 1 ? "X" : "O";
                CurrentBoard(_board);
                return true;
            }

            return false;
        }
    }
}
