using System;
using System.Collections.Generic;
using System.Text;

namespace HashTables
{
    class HashTable
    {
        public LinkedList<> Bucket;

        public int asciiValue (string key, LinkedList<> Bucket)
        {
            int value = 0;
            for (int i = 0; i < key.Length; i++)
            {
                value += key[i];
            }

            int hashedValue = (value * 1087) % Bucket.Length;

            return hashedValue;

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
