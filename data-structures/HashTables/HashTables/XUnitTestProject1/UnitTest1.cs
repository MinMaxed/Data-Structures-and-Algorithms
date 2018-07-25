using HashTables;
using System;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {


        [Fact]
        public void TestInsertion()
        {
            HashTable ht = new HashTable(1024);
            Node node = ht.Add("sushi", 2); 
            Node node2 = ht.Add("demi", 13); 
            Node node3 = ht.Add("coffee", 19); 
            Node node4 = ht.Add("kamehameha", 324);

            Assert.Equal(2, ht.Find("sushi"));
            Assert.Equal(13, ht.Find("demi"));
            Assert.Equal(19, ht.Find("coffee"));
            Assert.Equal(324, ht.Find("kamehameha"));
        }


        [Fact]
        public void TestContains()
        {
            HashTable ht = new HashTable(1024);
            Node node = ht.Add("sushi", 2);
            Node node2 = ht.Add("demi", 13);
            Node node3 = ht.Add("coffee", 19);
            Node node4 = ht.Add("kamehameha", 324);

            Assert.True(ht.Contains("sushi"));
            Assert.True(ht.Contains("demi"));
            Assert.True(ht.Contains("coffee"));
            Assert.True(ht.Contains("kamehameha"));
        }

        [Fact]
        public void TestCollisionSameAscii()
        {
            HashTable ht = new HashTable(1024);
            Node node = ht.Add("Cat", 2);
            Node node2 = ht.Add("Doe", 13);
            Node node3 = ht.Add("fat", 19);
            Node node4 = ht.Add("gas", 324);

            Assert.Equal(2, ht.Find("Cat"));
            Assert.Equal(13, ht.Find("Doe"));
            Assert.Equal(19, ht.Find("fat"));
            Assert.Equal(324, ht.Find("gas"));
        }
    }
}
