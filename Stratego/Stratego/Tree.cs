using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stratego
{
    class Tree
    {
        Node Root { get; set; }

        Tree(Node root)
        {Root = root;}

        Tree(int depth, Board board)
        {
            Root = new Node();
            createTree(board, depth, Root);
        }

        public void PostOrder(Node node)
        {
            foreach (var n in node.getChildrens())
                PostOrder(n);

            //Cos się dzieje
        }

        private void createTree(Board board,int depth,Node parent)
        {
            
            Node node = new Node();
            parent.addChild(node);
            for(int i=0;i<board.GameBoard.GetLength(0);i++)
            {
                for(int j=0;j<board.GameBoard.GetLength(1);j++)
                if(board.GameBoard[i,j]==0)
                {
                        Board tempBoard = new Board();
                        tempBoard.GameBoard = board.GameBoard.Clone() as int[,];
                        tempBoard.GameBoard[i, j] = 1;
                        createTree(tempBoard, depth - 1, node);
                }
            }
            
            

        }

    }
}
