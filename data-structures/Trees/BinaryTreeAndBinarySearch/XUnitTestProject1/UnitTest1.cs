using System;
using Xunit;
using BinaryTreeAndBinarySearch.Class;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void TestFindBinaryTree()
        {
            Node rootNode = new Node(5);
            BinaryTree BT = new BinaryTree(rootNode);
            Node node2 = new Node(2);
            Node node3 = new Node(3);
            Node node4 = new Node(6);
            Node node5 = new Node(7);
            Node node6 = new Node(8);

            rootNode.LeftChild = node2;
            node2.LeftChild = node3;
            node2.RightChild = node4;

            rootNode.RightChild = node5;
            node5.RightChild = node6;
            Node foundNode = BT.Search(rootNode,8);

            Assert.Equal(node6.Value, foundNode.Value);
        }


        [Fact]
        public void TestAddBinarySearchTree()
        {
            Node rootNode = new Node(6);
            BinarySearchTree bst = new BinarySearchTree(rootNode);
            Node node2 = new Node(2);
            Node node3 = new Node(3);
            Node node4 = new Node(5);
            Node node5 = new Node(7);
            Node node6 = new Node(8);
            Node node7 = new Node(10);

            bst.Add(rootNode, node2);
            bst.Add(rootNode, node3);
            bst.Add(rootNode, node4);
            bst.Add(rootNode, node5);
            bst.Add(rootNode, node6);
            bst.Add(rootNode, node7);


            Assert.Equal(rootNode.LeftChild.Value, node2.Value);
            Assert.Equal(rootNode.RightChild.Value, node5.Value);

        }



        [Fact]
        public void TestFindBinarySearchTree()
        {
            Node rootNode = new Node(6);
            BinarySearchTree bst = new BinarySearchTree(rootNode);
            Node node2 = new Node(2);
            Node node3 = new Node(3);
            Node node4 = new Node(5);
            Node node5 = new Node(7);
            Node node6 = new Node(8);

            bst.Add(rootNode, node2);
            bst.Add(rootNode, node3);
            bst.Add(rootNode, node4);
            bst.Add(rootNode, node5);
            bst.Add(rootNode, node6);

            Node foundNode = bst.Search(rootNode, 8);
            Node foundNode2 = bst.Search(rootNode, 5);
            Node foundNode3 = bst.Search(rootNode, 3);


            Assert.Equal(node6.Value, foundNode.Value);
            Assert.Equal(node4.Value, foundNode2.Value);
            Assert.Equal(node3.Value, foundNode3.Value);


        }
    }
}
