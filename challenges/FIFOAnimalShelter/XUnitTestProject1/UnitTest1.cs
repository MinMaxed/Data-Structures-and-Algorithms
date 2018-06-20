using System;
using Xunit;
using FIFOAnimalShelter;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void TestEnqueue()
        {
            Node node1 = new Node("dog");
            Node node2 = new Node("cat");
            Node node3 = new Node("cat");
            Node node4 = new Node("dog");
            Node node5 = new Node("cat");

            Queue animalShelter = new Queue(node1);

            animalShelter.Enqueue(node2);
            animalShelter.Enqueue(node3);
            animalShelter.Enqueue(node4);
            animalShelter.Enqueue(node5);

            Assert.Equal(node1.ValueAnimal, animalShelter.Front.ValueAnimal);
            Assert.Equal(node2.ValueAnimal, animalShelter.Front.Next.ValueAnimal);
            Assert.Equal(node5.ValueAnimal, animalShelter.Rear.ValueAnimal);




        }


        [Fact]
        public void TestDequeue()
        {
            Node node1 = new Node("dog");
            Node node2 = new Node("cat");
            Node node3 = new Node("cat");
            Node node4 = new Node("dog");
            Node node5 = new Node("cat");

            Queue animalShelter = new Queue(node1);
            animalShelter.Enqueue(node2);
            animalShelter.Enqueue(node3);
            animalShelter.Enqueue(node4);
            animalShelter.Enqueue(node5);



            Assert.Equal(node1.ValueAnimal, animalShelter.Dequeue("bird").ValueAnimal);
            Assert.Equal(node2.ValueAnimal, animalShelter.Dequeue("cat").ValueAnimal);
            Assert.Equal(node4.ValueAnimal, animalShelter.Dequeue("dog").ValueAnimal);


            //Assert.Equal(node2.ValueAnimal, animalShelter.Dequeue("cat").ValueAnimal);
            //Assert.Equal(node1.ValueAnimal, animalShelter.Dequeue("dog").ValueAnimal);
            //Assert.Equal(node3.ValueAnimal, animalShelter.Dequeue("bird").ValueAnimal);

        }


    }
}
