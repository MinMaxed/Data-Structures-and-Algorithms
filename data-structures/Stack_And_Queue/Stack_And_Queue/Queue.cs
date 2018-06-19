using System;
using System.Collections.Generic;
using System.Text;

namespace Stack_And_Queue
{
    public class Queue
    {
        public Node Front { get; set; }
        public Node Rear { get; set; }

        //queue constructor
        public Queue(Node node)
        {
            Front = node;
            Rear = Front;
        }


        //takes a new node and sets it to the rear by having the current rear's next value point to the new node
        public void Enqueue(Node node)
        {
            Rear.Next = node;
            Rear = node;
        }


        //store and remove the node at the front of the queue
        public Node Dequeue()
        {
            Node temp = Front;
            Front = Front.Next;
            temp.Next = null;
            return temp;
        }


        //look at the front of the queue to make sure it's not empty. 
        public Node Peek()
        {
            return Front;
        }


    }
}
