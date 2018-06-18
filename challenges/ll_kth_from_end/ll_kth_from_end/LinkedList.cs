using System;
using System.Collections.Generic;
using System.Text;

namespace ll_kth_from_end
{
    public class LinkedList
    {
        public Node Head { get; set; }
        public Node Current { get; set; }
        public Node Runner { get; set; }

        public LinkedList(Node node)
        {
            Head = node;
            Current = node;
            Runner = node;
        }

        /// <summary>
        /// logic for using a runner to go ahead of the Current in order to find a Node in relation to the end of a singly LL, without going over 
        /// over the List more than once
        /// </summary>
        /// <param name="k">The node we're looking for will be the K'th node from the end</param>
        /// <returns></returns>
        public Node KthElement(int k)
        {
            Current = Head;
            Runner = Head;
            int counter = 0;

            while (Runner.Next != null)
            {
                counter++;
                Runner = Runner.Next;
                if (counter > k)
                {
                    Current = Current.Next;
                }
            }
            if ( k > counter)
            {
                return null;
            }
            else
            {
                return Current;
            }
        }


        public Node Find(int value)
        {
            Current = Head;
            while (Current.Next != null)
            {
                if (Current.Value == value)
                {
                    return Current;
                }
                Current = Current.Next;
            }
            return Current.Value == value ? Current : null;
        }


        public void AddNode(Node node)
        {
            Current = Head;
            node.Next = Head;
            Head = node;
            Current = Head;
        }

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

    }
}
