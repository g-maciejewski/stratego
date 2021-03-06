﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stratego
{
    class Tree
    {
        public Node Root { get; set; }

        public Tree(Node root)
        {Root = root;}

        public Tree(int depth, Board board)
        {
            Root = new Node();
            createTree(board, depth, Root);
        }

        public void PostOrder(Node node)
        {
            if(node.getChildrens().Count!=0)
            foreach (var nd in node.getChildrens())
            {
                    Console.WriteLine("ilosc elementow w liscie: "+nd.getChildrens().Count);
                    if (nd.Position != null)
                    Console.WriteLine(nd.Position.ToString());
                else
                    Console.WriteLine("Brak wartosci");
                PostOrder(nd);  
            }
        }

        private void createTree(Board board,int depth,Node parent)
        {
            
            Node node = new Node();
            parent.addChild(node);
            
            for (int i=0;i<board.GameBoard.GetLength(0);i++)
            {
                for(int j=0;j<board.GameBoard.GetLength(1);j++)
                if(board.GameBoard[i,j]==0)
                {
                        Board tempBoard = new Board();
                        node.Position = new Tuple<int, int>(i, j);
                       // node.Position.Item2 = j;
                        tempBoard.GameBoard = board.GameBoard.Clone() as int[,];
                        tempBoard.GameBoard[i, j] = 1;
                        if(depth>=0)
                        createTree(tempBoard, depth - 1, node);
                }
            }
            Console.WriteLine("zakonczono33333333333333");
        }

    }
}
