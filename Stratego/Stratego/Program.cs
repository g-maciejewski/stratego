using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stratego
{
    class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board(3);
            Tree t = new Tree(3, board);
        }
    }
}
