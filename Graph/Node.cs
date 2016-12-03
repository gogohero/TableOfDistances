 using System.Collections.Generic;

namespace GraphNamespace
{
    public class Node
    {
        public Node()
        {
           this.Nodes = new List<Node>();
        }
        public List<Node> Nodes { get; set; }
        public int Index { get; set; }
      //  public  Element Element { get; set; }

    }
}
