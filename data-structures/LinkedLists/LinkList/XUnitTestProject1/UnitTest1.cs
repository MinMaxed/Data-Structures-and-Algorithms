using System;
using Xunit;
using LinkList;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void TestAddNode()
        {
            LinkedList ll = new LinkedList();
            Node testNode = new Node(3);
            Node testNode2 = new Node(4);
            ll.AddNode(testNode);
            ll.AddNode(testNode2);

            Assert.Equal(ll.Head.Value, testNode2.Value);

        }

        [Theory]
        [InlineData(2, 2)]
        [InlineData(8, 8)]

        public void TestFindNode(int valueInput, int valueFind)
        {
            LinkedList ll2 = new LinkedList();
            Node testNode1 = new Node(2);
            Node testNode2 = new Node(8);
            Node testNode3 = new Node(12);
            Node testNode4 = new Node(16);

            ll2.AddNode(testNode1);
            ll2.AddNode(testNode2);
            ll2.AddNode(testNode3);
            ll2.AddNode(testNode4);

            Node found = ll2.Find(valueInput);

            Assert.Equal(valueFind, found.Value);

        }

        [Theory]
        [InlineData(67)]
        [InlineData(42)]

        public void TestNullForNotFound(int test)
        {

            LinkedList ll3 = new LinkedList();
            Node testNode1 = new Node(2);
            Node testNode2 = new Node(8);
            Node testNode3 = new Node(12);
            Node testNode4 = new Node(16);

            ll3.AddNode(testNode1);
            ll3.AddNode(testNode2);
            ll3.AddNode(testNode3);
            ll3.AddNode(testNode4);

            Node cantFind = ll3.Find(test);

            Assert.Null(cantFind);
        }

    }
}
