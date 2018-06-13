using System;
using System.Collections.Generic;
using System.Text;

namespace LinkList
{
    public class LinkedList
    {

        /// <summary>
        /// always points ot the first node in a linked list
        /// </summary>
        public Node Head { get; set; }

        /// <summary>
        /// points to the 
        /// </summary>
        public Node Current { get; set; }

        public void LinkList(Node node)
        {
            Head = node;
            Current = node;
        }

        public void AddNode(Node node)
        {
            Current = Head;
            node.Next = Head;
            Head = node;
            Current = Head;
        }

        /// <summary>
        /// Find a node with a specific value
        /// </summary>
        /// <param name="value"> target value to search for</param>
        /// <returns>the node with the target value</returns>
        /// 
        public Node Find(int value)
        {
            Current = Head;
            while(Current.Next != null)
            {
                if ( Current.Value == value)
                {
                    return Current;
                }
                Current = Current.Next;
            }
            return Current.Value == value ? Current : null;
        }

        /// <summary>
        /// writes out the value of every node, through the last node. 
        /// </summary>
        /// 
        public void Print()
        {
            Current = Head;
            while (Current.Next != null)
            {
                Console.Write($"{Current.Value} -->");
                Current = Current.Next;
            }

            Console.Write($"{Current.Value} --> NULL");
        }

        /// <summary>
        /// adds a new Node before an existing one somewhere in the 'chain'
        /// </summary>
        /// <param name="newNode">the brand new node</param>
        /// <param name="existingNode">the node that the new node will be placed in front of</param>
        public void AddBefore(Node newNode, Node existingNode)
        {
            //reset our Current to the beginning of the List, 
            Current = Head;
           if(Head.Value == existingNode.Value)
            {
                AddNode(newNode);
                return;
            }
            //makes sure that you are not at the end of the list ie that existingNode does exist, 
            while (Current.Next != null)
            {   
                if (Current.Next.Value == existingNode.Value)
                {
                    newNode.Next = existingNode; //current.next;
                    Current.Next = newNode;
                    return;
                }
                Current = Current.Next;
            }
        }

        public void AddAfter(Node existingNode, Node newNode)
        {
            Current = Head;
            if (Head.Value == existingNode.Value)
            {
                Current.Next = newNode;
                return;
            }
            while ( Current.Next != null)
            {
                if (Current.Value == existingNode.Value)
                {
                    newNode.Next = Current.Next;
                    Current.Next = newNode;

                    return;
                }
                Current = Current.Next;
            }

        }
        

        /// <summary>
        /// finds the final node in the list then puts in the new node
        /// </summary>
        /// <param name="newNode"></param>
        public void AddLast(Node newNode)
        {
            Current = Head;

            while (Current.Next != null)
            {
                Current = Current.Next;
            }
            Current.Next = newNode;

        }
    }
}
