using System;
using System.Collections.Generic;
using System.Text;

namespace QueueWithStacks
{
    public class Queue
    {
        public Stack Stack1 { get; set; }
        public Stack Stack2 { get; set; }

        //queue constructor
        public Queue()
        {
            Stack1 = new Stack();
            Stack2 = new Stack();
        }

        /// <summary>
        /// the new node in the Queue is whatever was on top of Stack1. 
        /// </summary>
        /// <param name="value">value is whatever value in the stack you want 
        /// to add to the queue
        /// </param>
        /// <returns></returns>
        public Node Enqueue(int value)
        {
            Stack1.Push(new Node(value));
            return Stack1.Top;
        }


        /// <summary>
        /// while theres more than one node in Stack1, pop them off into stack2, then return 
        /// the last node in stack1, then put all the stack2 nodes back into stack1
        /// </summary>
        /// <returns></returns>
        public Node Dequeue()
        {
           
            while (Stack1.Top != null)
            {
                Stack2.Push(Stack1.Pop());
                if (Stack1.Top.Next == null)
                    Stack2.Push(Stack1.Pop());
            }

            return Stack2.Pop();
        }
    }
}
