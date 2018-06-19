using QueueWithStacks;
using System;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void TestEnqueue()
        {
            Stack stack = new Stack();
            Stack stack2 = new Stack();

            Queue testQueue = new Queue();

            Assert.Equal(5, testQueue.Enqueue(5).Value);
            Assert.Equal(10, testQueue.Enqueue(10).Value);
            Assert.Equal(20, testQueue.Enqueue(20).Value);
        }


        [Fact]
        public void TestDequeue()
        {
            Queue testQueue = new Queue();
            testQueue.Enqueue(5);
            testQueue.Enqueue(10);
            testQueue.Enqueue(15);
            testQueue.Enqueue(20);

            Assert.Equal(5, testQueue.Dequeue().Value);
            Assert.Equal(10, testQueue.Dequeue().Value);
            Assert.Equal(15, testQueue.Dequeue().Value);
            Assert.Equal(20, testQueue.Dequeue().Value);
        }
    }
}
