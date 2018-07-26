using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiBracketValidation
{
    public class Node
    {
        //basic node
        public char Value { get; set; }

        public Node Next { get; set; }

        public Node(char value)
        {
            Value = value;
        }
    }
}
