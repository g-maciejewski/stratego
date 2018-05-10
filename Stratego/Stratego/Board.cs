using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stratego
{
    class Board
    {
        int[,] board;

        public Board(int n) {
            board = new int[n,n];
        }

        public int GetPointsForMove(int lastChoiceColumn, int lastChoiceRow) {
            
        }

        public bool[,] GetAvaliableMoves() {
            bool[,] result = new bool[board.GetLength(0), board.GetLength(1)];

            for (int i = 0; i < board.GetLength(0); i++) {
                for (int j = 0; j < board.GetLength(1); j++) {
                    result[i, j] = board[i, j] == 0;
                }
            }

            return result;
        }
    }
}
