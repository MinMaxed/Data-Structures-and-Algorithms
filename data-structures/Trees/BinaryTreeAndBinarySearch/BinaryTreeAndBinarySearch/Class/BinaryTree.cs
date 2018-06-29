using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTreeAndBinarySearch.Class
{
    public class BinaryTree
    {

        /// <summary>
        /// traversals
        /// </summary>
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

        public void InOrder(Node root)
        {
            if (root.LeftChild != null)
            {
                InOrder(root.LeftChild);
            }

            Console.WriteLine(root.Value);

            if (root.RightChild != null)
            {
                InOrder(root.RightChild);
            }
        }

        public void PostOrder(Node root)
        {
            if (root.LeftChild != null)
            {
                PostOrder(root.LeftChild);
            }

            if (root.RightChild != null)
            {
                PostOrder(root.RightChild);
            }
            Console.WriteLine(root.Value);
        }

        public void BreadthFirst(Node root)
        {
            Queue<Node> breadth = new Queue<Node>();
            breadth.Enqueue(root);

            while (breadth.TryPeek(out root))
            {
                Node front = breadth.Dequeue();
                Console.Write(front.Value);

                if (front.LeftChild != null)
                {
                    breadth.Enqueue(front.LeftChild);
                }
                if (front.RightChild != null)
                {
                    breadth.Enqueue(front.RightChild);
                }
            }
        }


        public Node Search(Node root, int value)
        {

            if (root.Value == value)
            {
                return root;
            }

            if (root.LeftChild != null)
            {
                return Search(root.LeftChild, value);
            }

            if (root.RightChild != null)
            {

                return Search(root.RightChild, value);
            }

            return null;

        }

        public BinaryTree(Node node)
        {
        }
    }
}