using BinaryTreeAndBinarySearch.Class;
using System;

namespace BinaryTreeAndBinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            BinarySearchTree();
            //BinaryTree();
        }

        static void BinaryTree()
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

            BT.InOrder(rootNode);
            Console.ReadKey();
        }

        static void BinarySearchTree()
        {
            Node rootNode = new Node(5);
            BinarySearchTree bst = new BinarySearchTree(rootNode);

            Node node2 = new Node(2);
            Node node3 = new Node(3);
            Node node4 = new Node(6);
            Node node5 = new Node(7);
            Node node6 = new Node(8);

            bst.Add(rootNode, node2);
            bst.Add(rootNode, node3);
            bst.Add(rootNode, node4);
            bst.Add(rootNode, node5);
            bst.Add(rootNode, node6);

            bst.InOrder(rootNode);

            Console.ReadKey();
        }
    }
}
