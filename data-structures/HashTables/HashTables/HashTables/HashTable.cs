using System;
using System.Collections.Generic;
using System.Text;

namespace HashTables
{
    class HashTable
    {
        public LinkedList<> Bucket;

        public int asciiValue (string key)
        {
            int value = 0;
            for (int i = 0; i < key.Length; i++)
            {
                value += key[i];
            }

            return value;

        }

        public void Add(string key, int value)
        {

        }

        public int Find (int key)
        {

        }

        public bool Contains(int key)
        {

        }

        public HashTable GetHash(int key)
        {

        }
    }
}
