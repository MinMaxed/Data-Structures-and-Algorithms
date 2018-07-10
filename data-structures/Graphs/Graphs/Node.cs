using System;
using System.Collections.Generic;
using System.Text;

namespace Graphs
{
    public class Node
    {
        public string Value { get; set; }
        public bool Visited { get; set; } = false;
        public List<Node> Children { get; set; }

        public Node(string value)
        {
            Value = value;
            Children = new List<Node>();
        }

    }
}
