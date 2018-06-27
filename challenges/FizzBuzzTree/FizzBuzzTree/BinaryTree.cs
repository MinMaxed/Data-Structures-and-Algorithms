using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzzTree
{
    public class BinaryTree
    {
        public Node PreOrder(Node root)
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
            return root;
        }

        /// <summary>
        /// takes a tree's root and traverses the whole tree, fizz buzzing each node
        /// </summary>
        /// <param name="root">root of the tree</param>
        /// <returns>fizz buzzed tree</returns>
        public Node FizzBuzzTree(Node root)
        {
            if (root.Value != null)
            {
                root.Value = FizzBuzz(root.Value);
            }
            Console.WriteLine($"new root value is {root.Value}");

            if (root.LeftChild != null)
            {
                FizzBuzzTree(root.LeftChild);
            }

            if (root.RightChild != null)
            {
                FizzBuzzTree(root.RightChild);
            }
            return root;
        }
        /// <summary>
        /// Fizz Buzz's a string input since the return value has to be
        /// a string
        /// </summary>
        /// <param name="nodeValue">the string input that'll get modified</param>
        /// <returns>a fizz buzzed value to be put back into the nodes</returns>
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


        public BinaryTree(Node node)
        {
        }
    }
}
