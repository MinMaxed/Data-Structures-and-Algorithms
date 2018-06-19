using System;
using System.Collections.Generic;
using System.Text;

namespace QueueWithStacks
{
    public class Node
    {
        //basic node
        public int Value { get; set; }

        public Node Next { get; set; }

        public Node(int value)
        {
            Value = value;
        }

        public Node()
        { }
    }
}
