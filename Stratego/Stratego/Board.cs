using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stratego
{
    class Board
    {
        public int[,] GameBoard { get; set; }

        public Board(int n)
        {
            GameBoard = new int[n, n];
        }

        public Board()
        {
         
        }


        public bool[,] GetAvaliableMoves()
        {
            bool[,] result = new bool[GameBoard.GetLength(0), GameBoard.GetLength(1)];

            for (int i = 0; i < GameBoard.GetLength(0); i++)
            {
                for (int j = 0; j < GameBoard.GetLength(1); j++)
                {
                    result[i, j] = GameBoard[i, j] == 0;
                }
            }

            return result;
        }
    }
}
