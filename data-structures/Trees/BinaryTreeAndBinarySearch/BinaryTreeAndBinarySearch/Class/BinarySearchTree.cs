using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTreeAndBinarySearch.Class
{
    //public class BinarySearchTree : BinaryTree
    public class BinarySearchTree
    {
        public Node Search(Node root, int value)
        {
            if (root == null)
            {
                return null;
            }

            if (root.Value == value)
            {
                return root;
            }

            if (root.Value > value)
            {
                return Search(root.RightChild, value);
            }

            if (root.Value < value)
            {
                return Search(root.LeftChild, value);
            }
            else
            {
                return null;
            }
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
