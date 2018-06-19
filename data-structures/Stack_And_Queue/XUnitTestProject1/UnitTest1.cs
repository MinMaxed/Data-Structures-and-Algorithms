using System;
using Xunit;
using Stack_And_Queue;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void TestStackPush()
        {
            Node node1 = new Node(2);
            Node node2 = new Node(4);
            Node node3 = new Node(8);

            Stack stack = new Stack(node1);

            stack.Push(node2);
            Assert.Equal(4, stack.Top.Value);
            stack.Push(node3);
            Assert.Equal(8, stack.Top.Value);
        }

        [Fact]
        public void TestStackPop()
        {
            Node node1 = new Node(2);
            Node node2 = new Node(4);
            Node node3 = new Node(8);

            Stack stack = new Stack(node1);
            stack.Push(node2);
            stack.Push(node3);

            stack.Pop();
            Assert.Equal(4, stack.Top.Value);

            stack.Pop();
            Assert.Equal(2, stack.Top.Value);
        }

        [Fact]
        public void TestStackPeek()
        {
            Node node1 = new Node(2);
            Node node2 = new Node(4);
            Node node3 = new Node(8);
 

            Stack stack = new Stack(node1);

            stack.Push(node2);
            Assert.Equal(4, stack.Peek().Value);

            stack.Push(node3);
            Assert.Equal(8, stack.Peek().Value);
        }

        [Fact]
        public void TestQueueEnqueue()
        {
            Node node1 = new Node(2);
            Node node2 = new Node(4);
            Node node3 = new Node(8);
            Node node4 = new Node(16);
            Node node5 = new Node(32);

            Queue queue = new Queue(node1);
            queue.Enqueue(node2);
            Assert.Equal(2, queue.Front.Value);

            queue.Enqueue(node3);
            Assert.Equal(8, queue.Rear.Value);
        }

        [Fact]
        public void TestQueueDeQueue()
        {
            Node node1 = new Node(2);
            Node node2 = new Node(4);
            Node node3 = new Node(8);

            Queue queue = new Queue(node1);
            queue.Enqueue(node2);
            queue.Enqueue(node3);

            queue.Dequeue();
            Assert.Equal(4, queue.Front.Value);

            queue.Dequeue();
            Assert.Equal(8, queue.Front.Value);
        }

        [Fact]
        public void TestQueuePeek()
        {
            Node node1 = new Node(2);
            Node node2 = new Node(4);
            Node node3 = new Node(8);

            Queue queue = new Queue(node1);
            queue.Enqueue(node2);
            queue.Enqueue(node3);

            Assert.Equal(2, queue.Peek().Value);

            queue.Dequeue();
            Assert.Equal(4, queue.Peek().Value);
        }
    }
}
