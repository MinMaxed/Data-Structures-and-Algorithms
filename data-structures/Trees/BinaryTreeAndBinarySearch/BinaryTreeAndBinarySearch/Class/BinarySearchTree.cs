using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTreeAndBinarySearch.Class
{
    //public class BinarySearchTree : BinaryTree
    public class BinarySearchTree
    {
        /// <summary>
        /// while there's a value, check if it matches, otherwise go down the left
        /// side until there's no left, then go down the right
        /// </summary>
        /// <param name="root">the "current" of these traversals. </param>
        /// <param name="value"> the value of the node that we want to find</param>
        /// <returns></returns>
        public Node Search(Node root, int value)
        {
       
            if (root != null)
            {
                if (root.Value == value)
                {
                    return root;
                }

                if (root.Value > value)
                {
                    return Search(root.LeftChild, value);

                }
                if (root.Value < value)
                {
                    return Search(root.RightChild, value);

                }
           }
            return null;
        }

        /// <summary>
        /// add a new node
        /// </summary>
        /// <param name="Root"></param>
        /// <param name="newNode"></param>
        /// <returns></returns>
        public Node Add(Node Root, Node newNode)
        {
            if (Root == null)
            {
                Root = newNode;
                return Root;
            }

            if (Root.Value > newNode.Value)
            {
                if (Root.LeftChild == null)
                {
                    Root.LeftChild = newNode;
                }
                return Add(Root.LeftChild, newNode);
            }
            if (Root.Value < newNode.Value)
            {
                if (Root.RightChild == null)
                {
                    Root.RightChild = newNode;
                }
                return Add(Root.RightChild, newNode);
            }
            else
            {
                return null;
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


        /// <summary>
        /// constructor with a base node
        /// </summary>
        /// <param name="baseRoot"></param>
        public BinarySearchTree(Node baseRoot)
        {

        }
    }
}
