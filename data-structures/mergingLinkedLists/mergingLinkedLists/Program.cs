using System;
using mergingLinkedLists;

namespace mergingLinkedLists
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

         
         LinkedList LL1 = new LinkedList();
            LL1.AddNode(new Node(3));
            LL1.AddNode(new Node(7));
            LL1.AddNode(new Node(9));
            LL1.AddNode(new Node(11));
            LL1.AddNode(new Node(15));
            LL1.Print();
            Console.WriteLine();

            LinkedList LL2 = new LinkedList();
            LL2.AddNode(new Node(4));
            LL2.AddNode(new Node(8));
            LL2.AddNode(new Node(10));
            LL2.AddNode(new Node(14));
            LL2.AddNode(new Node(16));
            //LL2.AddNode(new Node(22));
            LL2.Print();
            Console.WriteLine();


            //LinkedList LL3 = new LinkedList();

            LL1.MergedLinkedLists(LL1, LL2);
            LL1.Print();
            Console.Read();

        }


    }
}
