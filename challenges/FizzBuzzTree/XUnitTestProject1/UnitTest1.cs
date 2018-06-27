using FizzBuzzTree;
using System;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void TestFizzBuzzTree()
        {
            Node root = new Node("3");
            Node node2 = new Node("5");
            Node node3 = new Node("8");
            Node node4 = new Node("15");
            Node node5 = new Node("7");
            Node node6 = new Node("11");
            Node node7 = new Node("30");

            BinaryTree BT = new BinaryTree(root);
            root.LeftChild = node2;
            root.RightChild = node3;

            node2.LeftChild = node4;
            node2.RightChild = node5;

            node3.LeftChild = node6;
            node3.RightChild = node7;

            BT.FizzBuzzTree(root);
            Assert.Equal("Fizz", root.Value);
            Assert.Equal("Buzz", node2.Value);
            Assert.Equal("FizzBuzz", node7.Value);
            Assert.Equal("11", node6.Value);

        }
    }
}
