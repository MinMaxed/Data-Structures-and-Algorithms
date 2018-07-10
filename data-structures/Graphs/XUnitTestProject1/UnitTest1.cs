using Graphs;
using System;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Node root = new Node("a");
            Node node1 = new Node("b");
            Node node2 = new Node("c");
            Node node3 = new Node("d");
            Node node4 = new Node("e");
            Node node5 = new Node("f");

            Graph graph = new Graph();

            graph.AddEdge(root, node1);
            graph.AddEdge(root, node2);
            graph.AddEdge(node1, node2);
            graph.AddEdge(node2, node3);
            graph.AddEdge(node1, node4);
            graph.AddEdge(node4, node5);
            graph.AddEdge(node3, node5);
        }
    }
}
