using System;
using System.Collections.Generic;

namespace Graphs
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Node root = new Node("a");
            Node node1 = new Node("b");
            Node node2 = new Node("c");
            Node node3 = new Node("d");
            Node node4 = new Node("e");
            Node node5 = new Node("f");

            Graph graph = new Graph();

            graph.AddEdge(root, node1);
            graph.AddEdge(root, node2);
            graph.AddEdge(root, node4);
            graph.AddEdge(node1, node2);
            graph.AddEdge(node1, node4);
            graph.AddEdge(node2, node3);
            graph.AddEdge(node3, node5);
            graph.AddEdge(node4, node5);

            //a looks at b, c, 
            Console.WriteLine($"{root.Value} --> {node1.Value}");
            Console.WriteLine($"{root.Value} --> {node2.Value}");
            Console.WriteLine($"{root.Value} --> {node4.Value}");

            //b looks at c and e
            Console.WriteLine($"{node1.Value} --> {node2.Value}");
            Console.WriteLine($"{node1.Value} --> {node4.Value}");

            // c looks at d
            Console.WriteLine($"{node2.Value} --> {node3.Value}");

            // d looks at f
            Console.WriteLine($"{node3.Value} --> {node5.Value}");

            // e looks at f
            Console.WriteLine($"{node4.Value} --> {node5.Value}");
            Console.WriteLine("---------------------");


            int Size = graph.Size(root);
            Console.WriteLine($"the graph size is {Size}");

            Console.WriteLine("---------------------");

            //traversal
            //List<Node> nodes = graph.BreadthFirst(root);
            var nodes = graph.BreadthFirst(root);

            foreach (var item in nodes)
            {
                Console.WriteLine($"{item.Value}");
            }

            Console.WriteLine("---------------------");




            //neighbors of root
            List<Node> neighbors = graph.GetNeighbors(root);

            foreach (var item in neighbors)
            {
                Console.WriteLine($"{item.Value} is a neighbor of {root.Value}");
            }
            Console.WriteLine("---------------------");
;


            Console.ReadLine();


        }


    }
}
