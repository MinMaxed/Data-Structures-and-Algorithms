using mergingLinkedLists;
using System;
using System.Collections.Generic;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void TestMergingListsEqualLength()
        {
            LinkedList LL1 = new LinkedList();
            LL1.AddNode(new Node(3));
            LL1.AddNode(new Node(7));
            LL1.AddNode(new Node(9));


            LinkedList LL2 = new LinkedList();
            LL2.AddNode(new Node(4));
            LL2.AddNode(new Node(8));
            LL2.AddNode(new Node(10));

            LinkedList LL3 = new LinkedList();
            LL3.AddNode(new Node(4));
            LL3.AddNode(new Node(3));
            LL3.AddNode(new Node(8));
            LL3.AddNode(new Node(7));
            LL3.AddNode(new Node(10));
            LL3.AddNode(new Node(9));


            Assert.Equal(LL3.Head, LL1.MergedLinkedLists(LL1, LL2));
        }

        //[Fact]
        //public void TestMergingListsLL1Longer()
        //{
        //    Assert.
        //}

        //[Fact]
        //public void TestMergingListsLL2Longer()
        //{
        //    Assert.
        //}
    }
}
