using System;
using System.Collections.Generic;
using System.Text;

namespace Graphs
{
    public class Node
    {
        public int Value { get; set; }
        public bool Visited { get; set; } = false;
        public Node Children { get; set; }
        public Node Edge { get; set; }

    }
}
