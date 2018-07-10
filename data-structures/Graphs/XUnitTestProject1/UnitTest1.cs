using Graphs;
using System;
using System.Collections.Generic;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void TestGetSize()
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

            int Size = graph.Size(root);

            Assert.Equal(6, Size);
        }

        [Fact]
        public void TestGetNeighbors()
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
            graph.AddEdge(root, node4);
            graph.AddEdge(node1, node4);
            graph.AddEdge(node2, node3);
            graph.AddEdge(node3, node5);
            graph.AddEdge(node4, node3);
            graph.AddEdge(node4, node5);

            List<Node> neighborsOfRoot = graph.GetNeighbors(root);
            List<Node> neighborsOfnodeE = graph.GetNeighbors(node4);
            List<Node> neighborsOfnodeC = graph.GetNeighbors(node2);



            Assert.Equal(3, neighborsOfRoot.Count);
            Assert.Equal(4, neighborsOfnodeE.Count);
            Assert.Equal(2, neighborsOfnodeC.Count);


        }
    }
}
