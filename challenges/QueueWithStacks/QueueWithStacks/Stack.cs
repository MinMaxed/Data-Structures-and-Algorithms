using System;
using System.Collections.Generic;
using System.Text;

namespace QueueWithStacks
{
    public class Stack
    {
        public Node Top { get; set; }

        public Node Bottom { get; set; }


        //Stack constructor
        public Stack(Node node)
        {
            Top = node;
        }


        //sets the new node as the top in the stack
        public void Push(Node node)
        {
            node.Next = Top;
            Top = node;
        }

        //removes the node on the top of the stack
        public Node Pop()
        {
            Node temp = Top;
            Top = Top.Next;
            temp.Next = null;
            return temp;
        }

        //use to look and make sure there is
        public Node Peek()
        {
            return Top;
        }

    }
}
