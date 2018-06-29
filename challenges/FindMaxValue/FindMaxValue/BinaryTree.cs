using System;
using System.Collections.Generic;
using System.Text;

namespace FindMaxValue
{
    public class BinaryTree
    {
 

        /// <summary>
        /// Takes in a Binary Tree, uses a Bredth First traversal to look at every node
        /// at each one, checks the stored 'max value' against the current value 
        /// and reassigned if new value is bigger
        /// </summary>
        /// <param name="root">start of the tree</param>
        /// <returns>Max value</returns>
        public int FindMe(Node root)
        {
            Queue<Node> breadth = new Queue<Node>();
            breadth.Enqueue(root);
                int maxValue = 0;

            while (breadth.TryPeek(out root))
            {
                Node front = breadth.Dequeue();
                Type type = typeof(int);

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

        /// <summary>
        /// constructor that takes in a root
        /// </summary>
        /// <param name="root">start of tree</param>
        public BinaryTree(Node root)
        {

        }
    }
}
