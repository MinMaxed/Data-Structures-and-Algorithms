using System;

namespace FindMaxValue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Node root = new Node(3);
            Node node2 = new Node(5);
            Node node3 = new Node(8);
            Node node4 = new Node(15);
            Node node5 = new Node(7);
            Node node6 = new Node(17);
            Node node7 = new Node(2);

            BinaryTree BT = new BinaryTree(root);
            root.LeftChild = node2;
            root.RightChild = node3;

            node2.LeftChild = node4;
            node2.RightChild = node5;

            node3.LeftChild = node6;
            node3.RightChild = node7;

            int Me = BT.FindMe(root);
            Console.WriteLine(Me);
            Console.ReadKey();
        }
    }
}
