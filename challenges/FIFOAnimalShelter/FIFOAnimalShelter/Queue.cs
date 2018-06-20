using System;
using System.Collections.Generic;
using System.Text;

namespace FIFOAnimalShelter
{
    public class Queue
    {
        public Node Front { get; set; }
        public Node Rear { get; set; }
        public Node Current { get; set; }
        public Node temp { get; set; }

        //queue constructor
        public Queue(Node node)
        {
            Front = node;
            Rear = Front;
        }

        public void Print()
        {
            Current = Front;
            while (Current.Next != null)
            {
                Console.Write($"{Current.ValueAnimal} -->");
                Current = Current.Next;
            }

            Console.Write($"{Current.ValueAnimal} --> NULL");
        }


        //takes a new node and sets it to the rear by having the current rear's next value point to the new node
        public void Enqueue(Node animal)
        {
            Rear.Next = animal;
            Rear = animal;
        }

        /// <summary>
        /// Returns the Front if the search isn't cat or dog
        /// but also if the Front's value is what is the pref
        /// Loops through until it finds the pref and returns it, 
        /// if the pref isn't in the list, it returns the Front
        /// </summary>
        /// <param name="pref">search term, expecting cat or dog</param>
        /// <returns></returns>
        public Node Dequeue(string pref)
        {
            Current = Front;
            Node temp = Front;
            Node temp2 = Front;

            if (pref != "cat" && pref != "dog")
            {
                temp = Front;
                Front = Front.Next;
                temp.Next = null;
                return temp;
            }
            if (pref == "dog" || pref == "cat")
            {
                if (Front.ValueAnimal == pref)
                {
                    temp = Front;
                    Front = Front.Next;
                    temp.Next = null;
                    return temp;
                }
                else
                {
                    while (Current.ValueAnimal != pref)
                    {
                        if (Current.Next == null)
                        {
                            temp = Front;
                            Front = Front.Next;
                            temp.Next = null;
                            return temp;
                        }
                        Current = Current.Next;
                        temp2 = Current.Next;
                        Current.Next = temp2.Next;
                        temp2.Next = null;
                    }
                    return temp2;
                }
            }
            return temp2;
        }
    }
}
