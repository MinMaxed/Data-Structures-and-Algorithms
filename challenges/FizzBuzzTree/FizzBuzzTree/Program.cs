using System;


namespace FizzBuzzTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Node root = new Node("3");
            Node node2 = new Node("5");
            Node node3 = new Node("8");
            Node node4 = new Node("15");
            Node node5 = new Node("7");
            Node node6 = new Node("11");
            Node node7 = new Node("30");

            BinaryTree BT = new BinaryTree(root);
            root.LeftChild = node2;
            root.RightChild = node3;

            node2.LeftChild = node4;
            node2.RightChild = node5;

            node3.LeftChild = node6;
            node3.RightChild = node7;

            BT.FizzBuzzTree(root);
            Console.ReadKey();

        }


   

        public string FizzBuzz(string nodeValue)
        {
            int value = Convert.ToInt32(nodeValue);
            string returnValue;

            if (value % 3 == 0 && value % 5 == 0)
            {
                returnValue = "FizzBuzz";
                return returnValue;
            }
            if (value % 3 == 0)
            {
                returnValue = "Fizz";
                return returnValue;
            }
            if (value % 5 == 0)
            {
                returnValue = "Buzz";
                return returnValue;
            }
            else
                return nodeValue;
        }
    }
}

