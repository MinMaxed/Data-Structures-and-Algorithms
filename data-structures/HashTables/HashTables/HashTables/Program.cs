using System;

namespace HashTables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            HashTableMadness();
     
        }

        public static void HashTableMadness()
        {
            HashTable ht = new HashTable(1024);
            Node node = ht.Add("sushi", 2);
            Node node2 = ht.Add("demi", 13);
            Node node3 = ht.Add("coffee", 19);
            Node node4 = ht.Add("kamehameha", 324);


            Console.WriteLine("confirming it contains added nodes");
            Console.WriteLine(ht.Contains("sushi"));
            Console.WriteLine(ht.Contains("demi"));
            Console.WriteLine(ht.Contains("coffee"));
            Console.WriteLine(ht.Contains("kamehameha"));


            Console.WriteLine("Finding nodes");
            Console.WriteLine(ht.Find("sushi"));
            Console.WriteLine(ht.Find("demi"));
            Console.WriteLine(ht.Find("coffee"));
            Console.WriteLine(ht.Find("kamehameha"));

            Console.WriteLine("Forcing collisions");
            ht.Add("Cat", 4);
            ht.Add("Doe", 9);
            ht.Add("fat", 17);
            ht.Add("gas", 20);

            Console.WriteLine($"Cat has an ascii value of {ht.asciiValue("Cat")}");
            Console.WriteLine($"Doe has an ascii value of {ht.asciiValue("Doe")}");
            Console.WriteLine($"fat has an ascii value of {ht.asciiValue("fat")}");
            Console.WriteLine($"gas has an ascii value of {ht.asciiValue("gas")}");




            Console.ReadKey();

        }
    }
}
