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

        public void PostOrder(Node node)
        {
            foreach (var n in node.getChildrens())
                PostOrder(n);

            //Cos się dzieje
        }

    }
}
