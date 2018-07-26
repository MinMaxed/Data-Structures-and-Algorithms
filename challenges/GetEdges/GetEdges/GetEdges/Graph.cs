using System;
using System.Collections.Generic;
using System.Text;

namespace Graphs
{
    public class Graph
    {
        public Graph()
        {

        }
        /// <summary>
        /// add node as child of first node
        /// </summary>
        /// <param name="node1">parent node</param>
        /// <param name="node2">child node</param>
        /// <returns>parent node</returns>
        public Node AddEdge(Node node1, Node node2)
        {
            node1.Children.Add(node2);
            node2.Children.Add(node1);

            return node1;
        }

        public Node AddWeightedEdge(Node node1, Node node2, int weight)
        {
            node1.Edges.Add(node2, weight);
            node2.Edges.Add(node1, weight);

            return node1;
        }



        /// <summary>
        /// traverse all nodes and add em to a list
        /// </summary>
        /// <param name="root">starting point of graph</param>
        /// <returns>the traversal of all the nodes in the graph</returns>
        public List<Node> GetNodes(Node root)
        {
            return BreadthFirst(root);

        }

        /// <summary>
        /// get the nodes connected to the root, or its children
        /// </summary>
        /// <param name="root">starting out point</param>
        /// <returns>children of the root</returns>
        public List<Node> GetNeighbors(Node root)
        {
            List<Node> Neighbors = new List<Node>(root.Children);

            return Neighbors;
        }

        /// <summary>
        /// traverses graph then returns the Count
        /// </summary>
        /// <param name="root">graph starting point</param>
        /// <returns>amount of nodes found in traversal</returns>
        public int Size(Node root)
        {
            var orderSize = this.BreadthFirst(root);


            return orderSize.Count;
        }

        /// <summary>
        /// traverse a graph
        /// </summary>
        /// <param name="root">starting point</param>
        /// <returns>list of nodes in the graph</returns>
        public List<Node> BreadthFirst(Node root)
        {
            List<Node> order = new List<Node>();
            Queue<Node> breadth = new Queue<Node>();
            breadth.Enqueue(root);
            //placement could be wrong
            root.Visited = true;

            while (breadth.TryPeek(out root))
            {
                Node front = breadth.Dequeue();

                order.Add(front);

                foreach (Node child in front.Children)
                {
                    if (!child.Visited)
                    {
                        child.Visited = true;
                        breadth.Enqueue(child);
                    }
                }
            }
            foreach (var node in order)
            {
                node.Visited = false;
            }
            return order;
        }

    }
}
