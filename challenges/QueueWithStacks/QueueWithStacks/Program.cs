using System;

namespace QueueWithStacks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Node node1 = new Node(5);
            Node node2 = new Node(10);
            Node node3 = new Node(15);
            Node node4 = new Node(20);

            Stack stack = new Stack(node1);
            stack.Push(node2);
            stack.Push(node3);
            stack.Push(node4);
            Stack stack2 = new Stack();

            while(stack.Top.Next != null)
            {                
            stack2.Push(stack.Pop());

            }
            Console.WriteLine();


            Queue testQueue = new Queue();



        }



        public void QueueWithStacks()
        {

        }
    }
}
