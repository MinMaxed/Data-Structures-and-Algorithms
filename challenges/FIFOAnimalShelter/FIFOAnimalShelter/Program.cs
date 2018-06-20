using System;

namespace FIFOAnimalShelter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            FIFOAnimalShelter();
        }

        static void FIFOAnimalShelter()
        {
            Node node1 = new Node("cat");
            Node node2 = new Node("cat");
            Node node3 = new Node("cat");
            Node node4 = new Node("cat");
            Node node5 = new Node("cat");

            Queue animalShelter = new Queue(node1);

            animalShelter.Enqueue(node2);
            animalShelter.Enqueue(node3);
            animalShelter.Enqueue(node4);
            animalShelter.Enqueue(node5);

            animalShelter.Print();
            Console.WriteLine("----------");

            animalShelter.Dequeue("cat");
            animalShelter.Dequeue("bird");
            animalShelter.Dequeue("dog");

            animalShelter.Print();
            Console.ReadKey();
        }
    }
}
