using System;
using Xunit;
using ll_kth_from_end;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(1, 3)]
        [InlineData(2, 5)]
        [InlineData(5, 29)]

        public void TestKthElement(int testValue, int testResult)
        {
            
            LinkedList linkedList = new LinkedList(new Node(2));
            linkedList.AddNode(new Node(3));
            linkedList.AddNode(new Node(5));
            linkedList.AddNode(new Node(8));
            linkedList.AddNode(new Node(17));
            linkedList.AddNode(new Node(29));

            Node result = linkedList.KthElement(testValue);
            Assert.Equal(testResult, result.Value);
        }
    }
}
