using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTreeAndBinarySearch.Class
{
    class BinarySearch
    {

        public Node Search(Node root, int value)
        {
            if(root == null)
            {
                return null;
            }

            if(root.Value == value)
            {
                return root;
            }
        }
    }
}
