using System;

namespace Stack_And_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Stacking();
            Queueing();
        }

        public static void Stacking()
        {
            Node node1 = new Node(2);
            Node node2 = new Node(4);
            Node node3 = new Node(8);
            Node node4 = new Node(16);
            Node node5 = new Node(32);

            Stack stack = new Stack(node1);

            //adding nodes to the stack, Top's value is 32
            stack.Push(node2);
            stack.Push(node3);
            stack.Push(node4);
            stack.Push(node5);

            int peekValue = stack.Peek().Value;
            //look at Top, should be 32
            Console.WriteLine(peekValue);

            //removes the node at the Top, 32, and new Top will be node value 16
            stack.Pop();

            peekValue = stack.Peek().Value;
            //will be 16
            Console.WriteLine(peekValue);
            Console.ReadKey();
        }

        public static void Queueing()
        {
            Node node1 = new Node(2);
            Node node2 = new Node(4);
            Node node3 = new Node(8);
            Node node4 = new Node(16);
            Node node5 = new Node(32);

            Queue queue = new Queue(node1);

            //adding stacks in the queue, Front will be 2, Rear will be 32
            queue.Enqueue(node2);
            queue.Enqueue(node3);
            queue.Enqueue(node4);
            queue.Enqueue(node5);

            //peek at the Front, value is 2
            int queuePeekValue = queue.Peek().Value;
            Console.WriteLine(queuePeekValue);

            //removing the front in the que, new Front will be 4
            queue.Dequeue();
            queuePeekValue = queue.Peek().Value;
            Console.WriteLine(queuePeekValue);
            Console.ReadKey();
        }
    }
}
