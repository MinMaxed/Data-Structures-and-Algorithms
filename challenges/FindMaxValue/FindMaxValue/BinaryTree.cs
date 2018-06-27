using System;
using System.Collections.Generic;
using System.Text;

namespace FindMaxValue
{
    public class BinaryTree
    {
        public void PreOrder(Node root)
        {

            Console.WriteLine(root.Value);

            if (root.LeftChild != null)
            {
                PreOrder(root.LeftChild);
            }

            if (root.RightChild != null)
            {
                PreOrder(root.RightChild);
            }
        }

        public int MaxValue(int checkValue)
        {
            int maxValue = 0;
            if (maxValue < checkValue)
            {
                maxValue = checkValue;
            }
            return maxValue;
        }
        public int FindMe(Node root)
        {
            Queue<Node> breadth = new Queue<Node>();
            breadth.Enqueue(root);
                int maxValue = 0;

            while (breadth.TryPeek(out root))
            {
                Node front = breadth.Dequeue();

                if (maxValue < root.Value)
                {
                    maxValue = root.Value;
                }

                if (front.LeftChild != null)
                {
                    breadth.Enqueue(front.LeftChild);
                }
                if (front.RightChild != null)
                {
                    breadth.Enqueue(front.RightChild);
                }
            }
            return maxValue;
        }

        public BinaryTree(Node root)
        {

        }
    }
}
