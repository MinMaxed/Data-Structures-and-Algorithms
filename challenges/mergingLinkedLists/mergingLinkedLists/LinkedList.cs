using System;
using System.Collections.Generic;
using System.Text;

namespace mergingLinkedLists
{
    public class LinkedList
    {

        public Node Head { get; set; }
        public Node Current { get; set; }
        public Node Current1 { get; set; }
        public Node Current2 { get; set; }
        public Node Runner1 { get; set; }
        public Node Runner2 { get; set; }


        public void LinkList(Node node)
        {
            Head = node;
            Current = node;
        }

        public void AddNode(Node node)
        {
            Current = Head;
            node.Next = Head;
            Head = node;
            Current = Head;
        }

        public Node Find(int value)
        {
            Current = Head;
            while (Current.Next != null)
            {
                if (Current.Value == value)
                {
                    return Current;
                }
                Current = Current.Next;
            }
            return Current.Value == value ? Current : null;
        }

        public void Print()
        {
            Current = Head;
            while (Current.Next != null)
            {
                Console.Write($"{Current.Value} -->");
                Current = Current.Next;
            }

            Console.Write($"{Current.Value} --> NULL");
        }

        public void AddBefore(Node newNode, Node existingNode)
        {
            //reset our Current to the beginning of the List, 
            Current = Head;
            if (Head.Value == existingNode.Value)
            {
                AddNode(newNode);
                return;
            }
            //makes sure that you are not at the end of the list ie that existingNode does exist, 
            while (Current.Next != null)
            {
                if (Current.Next.Value == existingNode.Value)
                {
                    newNode.Next = existingNode; //current.next;
                    Current.Next = newNode;
                    return;
                }
                Current = Current.Next;
            }
        }

        public void AddAfter(Node existingNode, Node newNode)
        {
            Current = Head;
            if (Head.Value == existingNode.Value)
            {
                Current.Next = newNode;
                return;
            }
            while (Current.Next != null)
            {
                if (Current.Value == existingNode.Value)
                {
                    newNode.Next = Current.Next;
                    Current.Next = newNode;

                    return;
                }
                Current = Current.Next;
            }

        }

        public void AddLast(Node newNode)
        {
            Current = Head;

            while (Current.Next != null)
            {
                Current = Current.Next;
            }
            Current.Next = newNode;
        }

        public Node MergedLinkedLists(LinkedList LL1, LinkedList LL2)
        {
            LL1.Current = LL1.Head;
            LL2.Current = LL2.Head;

            Runner1 = LL1.Head;
            Runner2 = LL2.Head;

            while (Runner1.Next != null && Runner2.Next != null)
            {
                Runner1 = Runner1.Next;
                Runner2 = Runner2.Next;

                LL2.Current.Next = LL1.Current.Next;
                LL1.Current.Next = LL2.Current;

                LL1.Current = Runner1;
                LL2.Current = Runner2;
            }
            if (LL2.Current.Next == null)
            
                LL2.Current.Next = LL1.Current.Next;
            
            LL1.Current.Next = LL2.Current;

            return LL1.Head;
        }
    }

    
                //if (Current1.Next != null)
                //{
                //    Current = Current.Next;
                //    Current1 = Current1.Next;
                //    Current.Next = Current1;
                //}
                //if (Current2.Next != null)
                //{
                //    Current = Current.Next;
                //    Current2 = Current2.Next;
                //    Current.Next = Current2;
                //}
}