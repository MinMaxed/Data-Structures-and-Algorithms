using System;
using System.Collections.Generic;
using System.Text;

namespace FindMaxValue
{
    public class Node
    {
        public int Value { get; set; }
        public Node Next { get; set; }

        public Node LeftChild { get; set; }
        public Node RightChild { get; set; }
        public Node Root { get; set; }


        public Node(int value)
        {
            Value = value;
        }
    }
}
