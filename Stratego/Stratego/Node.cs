using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stratego
{
    class Node
    {
        int Value { get; set; }
        int Alpha { get; set; }
        int Beta { get; set; }
        private List<Node> childs;

        Node(int v, List<Node> childrens)
        {
            Value = v;
            childs = childrens;
        }

        public List<Node> getChildrens()
        {return childs;}


    }
}
