using System;
using System.Collections.Generic;
using System.Text;

namespace FIFOAnimalShelter
{
    public class Node
    {
        public int Value { get; set; }

        public Node Next { get; set; }

        public string ValueAnimal { get; set; }

        public Node(int value)
        {
            Value = value;
        }

        public Node(string animal)
        {
            ValueAnimal = animal;
        }
    }
}
