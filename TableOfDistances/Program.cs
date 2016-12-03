using System;
using System.Collections.Generic;
using System.Linq;

namespace TableOfDistances
{
    using GraphNamespace;

    class Program
    {
        static void Main()
        {
            Graph graph = new Graph();
          //  int graphCount = graph.CountOfNodes;
            


             string command = Console.ReadLine();


                        while (command != "End")
                        {
            
                            string[] operations = command.Split(' ');
                            var node = new Node();
                            if (operations[0] == "Add")
                            {
            
                                graph.Add(node);
                            }
                            else if (operations[0] == "Connect")
                            {
            
                                var connectionNodes = new List<Node>();
                                for (int i = 2; i < operations.Length; i++)
                                {
                                    graph.Nodes[int.Parse(operations[1]) - 1].Nodes.Add(graph.Nodes[int.Parse(operations[i - 1])]);
                                    graph.Nodes[int.Parse(operations[i - 1])].Nodes.Add(graph.Nodes[int.Parse(operations[1]) - 1]);
                                }
            
                            }
                            command = Console.ReadLine();
            
                        }
            int[,] connectionTable = ToConnectionTable(graph);


        }

        public static int[,] ToConnectionTable(Graph graph)
        {
            int nodesCount = graph.Nodes.Count;
            int[,] CTArray = new int[nodesCount, nodesCount]; // conectiontable Array
            for (int i = 0; i < nodesCount; i++)
            {
                for (int j = 0; j < nodesCount; j++)
                {GetDistance(graph.Nodes[i], graph.Nodes[j], graph, 0);
                    CTArray[i, j] = lenghts.Min();
                    lenghts.Clear();
                    usedInRecursion.Clear();
                }
            }
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            for (int i = 0; i <= nodesCount; i++)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine();
            for (int i = 0; i < nodesCount; i++)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write((i+1)+ " ");
                Console.ResetColor();
                for (int j = 0; j< nodesCount; j++)
                {
                    Console.Write(CTArray[i,j]+ " ");
                }
                Console.WriteLine();
            }
            return CTArray;
        }
       private static List<Node> usedInRecursion = new List<Node>();
        private static List<int> lenghts = new List<int>();
        private static int GetDistance(Node firstNode, Node secondNode, Graph graph, int depth)
        {
            if (firstNode == secondNode)
            {   
                lenghts.Add(depth);
                return depth; 
            }
            usedInRecursion.Add(firstNode);
            for (int i = 0; i < firstNode.Nodes.Count;i++)
            {
                
                if (!usedInRecursion.Contains(firstNode.Nodes[i]))
                {depth++;
                    GetDistance(firstNode.Nodes[i], secondNode, graph, depth);
                    depth--;
                }
            }
            
            return -1;
        }




    }

    internal class IdAttribute : Attribute
    {
    }
}

