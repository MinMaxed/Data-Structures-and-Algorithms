using System;
using System.IO;


namespace ll_kth_from_end
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Int32.TryParse(Console.ReadLine(), out int searchValue);
            RunTheProgram();
            Console.Read();
        }

        public static void RunTheProgram()
        {
            Node node = new Node(4);
            Node node2 = new Node(7);
            Node node3 = new Node(8);
            Node node4 = new Node(9);
            Node node5 = new Node(11);
            Node node6 = new Node(15);
            Node[] nodeArray = new Node[] { node2, node3, node4, node5, node6 };

            LinkedList myList = new LinkedList(node);

            foreach(Node i in nodeArray)
            {
                myList.AddNode(i);
                Console.WriteLine("node added");                
            }

            Node kthNode = myList.KthElement(4);
            try
            {
            Console.WriteLine($"{kthNode.Value} was hit");
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine($"Exception {e.Message}");
            }
            myList.Print();

        }
    }
}
