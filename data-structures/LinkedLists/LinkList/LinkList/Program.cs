using System;

namespace LinkList
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            LinkedList ll = new LinkedList();
            Node testNode1 = new Node(2);
            Node testNode2 = new Node(8);
            Node testNode3 = new Node(12);
            Node testNode4 = new Node(16);

            //Adding Nodes, 
            ll.AddNode(testNode1);
            ll.AddNode(testNode2);
            ll.AddNode(testNode3);
            ll.AddNode(testNode4);

            ll.Print();
            Console.WriteLine("--");
            Console.WriteLine("------adding node^ -----");

            //Finding a node
           Node found = ll.Find(testNode3.Value);
            Console.WriteLine(found.Value);
            Console.WriteLine("");
            Console.WriteLine("--finding node^ -----");
            Console.WriteLine("");



            //add before
            Node testNode5 = new Node(20);

            ll.AddBefore(testNode5, testNode3);
            ll.Print();
            Console.WriteLine("");
            Console.WriteLine("-adding before node^ --");
            Console.WriteLine("");



            //add after
            Node testNode6 = new Node(24);
            ll.AddAfter(testNode2, testNode6);
            ll.Print();
            Console.WriteLine("");
            Console.WriteLine("---adding after node^ -----");
            Console.WriteLine("");



            //add last
            Node testNode7 = new Node(28);

            ll.AddLast(testNode7);
            ll.Print();
            Console.WriteLine("");
            Console.WriteLine("---adding last node^ -----");
            Console.WriteLine("");

            Console.ReadKey();











        }
    }
}
