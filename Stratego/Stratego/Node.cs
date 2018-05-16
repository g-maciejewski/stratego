using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stratego
{
    class Node
    {
        public Tuple<int, int> Position { get; set; }
        int Alpha { get; set; }
        int Beta { get; set; }
        private List<Node> childs;
        public Node(int v, List<Node> childrens)
        {
            Value = v;
            childs = childrens;
        }
        
        public Node()
        {
            childs = new List<Node>();
        }

        public List<Node> getChildrens()
        {return childs;}

        public void addChild(Node child)
        {
            childs.Add(child);
        }

    }
}
