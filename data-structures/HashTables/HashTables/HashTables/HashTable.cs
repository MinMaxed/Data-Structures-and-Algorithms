using System;
using System.Collections.Generic;
using System.Text;

namespace HashTables
{
    class HashTable
    {
        public Node[] Bucket { get; set; }

        public HashTable()
        {
            Bucket = new Node[1024];
        }

        /// <summary>
        /// make an ascii value to make key unique
        /// </summary>
        /// <param name="key">key to ascii</param>
        /// <returns>its hashed value</returns>
        public int asciiValue (string key)
        {
            decimal value = 0;
            for (int i = 0; i < key.Length; i++)
            {
                value += key[i];
            }

            int hashedValue = (int)Math.Floor((value * 1087) % Bucket.Length);

            return hashedValue;

        }

        /// <summary>
        /// adss a node to the table
        /// </summary>
        /// <param name="key">key of added node</param>
        /// <param name="value">value of added node</param>
        public void Add(string key, int value)
        {
            Node node = new Node
            {
                Key = key,
                Value = value
            };

            int i = asciiValue(key);
            if(Bucket[i] != null)
            {
                node.Next = Bucket[i];
            }
            Bucket[i] = node;     
        }

        /// <summary>
        /// search for a key, and return its value if found
        /// </summary>
        /// <param name="key">key searching for</param>
        /// <returns>key's value</returns>
        public int Find (string key)
        {
            int i = asciiValue(key);
            Node current = Bucket[i];

            while (current.Next != null)
            {
                if (current.Key == key)
                {
                    return current.Value;
                }
                current = current.Next;
            }
            return current.Value;
        }



        /// <summary>
        /// check to see if the table contains key
        /// </summary>
        /// <param name="key">value to hunt for</param>
        /// <returns>yes or no if it contains</returns>
        public bool Contains(string key)
        {
            int i = asciiValue(key);
            if (Bucket[i] != null)
            {
                Node current = Bucket[i];
                while (current.Next != null)
                {
                    if (current.Key == key)
                    {
                        return true;
                    }
                    current = current.Next;
                }
                if (current.Key == key)
                {
                    return true;
                }
            }
            return false;
        }
    }
}

    

