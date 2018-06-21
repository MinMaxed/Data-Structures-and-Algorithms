using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiBracketValidation
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string input = "()[[Extra Characters]";
            Queue testQueue = InputsQueue(input);

            MultiBracketValidation(testQueue);
        }

        public static Queue InputsQueue(string input)
        {
            Queue queue = new Queue(new Node('n'));
            char[] inputArray = input.ToCharArray();
            char[] bracketArray = new char[] { '[', ']', '{', '}', '(', ')' };

            foreach (char item in inputArray)
            {
                foreach (char bracket in bracketArray)
                {
                    if (bracket == item)
                    {
                        queue.Enqueue(new Node(item));
                    }
                }
            }
            queue.Dequeue();

            return queue;
        }

        public static bool MultiBracketValidation(Queue queue)
        {
            //bool valid = false;
            while (queue.Front != null)
            {
                char checking = queue.Dequeue().Value;
                char checkingAgainst;

                switch (checking)
                {
                    case '[':
                        checkingAgainst = ']';
                        break;
                    case '{':
                        checkingAgainst = '}';
                        break;
                    case '(':
                        checkingAgainst = ')';
                        break;
                    default:
                        return false;
                }

                //check final node to know when its looped through the queue a full cycle
                Node finalNode = queue.Rear;
                while ( queue.Front.Value != checkingAgainst && queue.Front != finalNode)
                {
                    //Node requeue = queue.Dequeue();
                    queue.Enqueue(queue.Dequeue());
                }
                if (queue.Front.Value == checkingAgainst)
                {
                    queue.Dequeue();
                    
                    try
                    {
                    while (finalNode != queue.Rear)
                    {
                        queue.Enqueue(queue.Dequeue());
                    }

                    } catch (NullReferenceException)
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
    }
}
