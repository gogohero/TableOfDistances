using System;
using System.Collections.Generic;
 

namespace GraphNamespace
{
    public delegate int Por(int a);
    public class Graph
    {
        public List<Node> Nodes { get; set; }
        public int CountOfNodes { get; set; }
        public Graph()
        {
            this.Nodes = new List<Node>();
            CountOfNodes = 0;
        }

        public void Add(Node node)
        {
            CountOfNodes++;
            node.Index = CountOfNodes;
           
                this.Nodes.Add(node); 
           
        }

       private void RemoveByIndex(int index)
        {
            Nodes.RemoveAll(node => node.Index == index); 
          
        }

        
       

         

       
        
    }
}
