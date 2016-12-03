using System;
using System.Collections.Generic;
using System.Linq;
using GraphNamespace;

namespace Graph
{
    static class ExtentionMethods
    {
        public static void Add(this List<Node> Nodes, Node node)
        {
            Nodes.RemoveAll(x => x == node);
            Nodes.Add(node);
        }
    }
}
