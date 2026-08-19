using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingPractice.Hashing_LinkedList
{
    public class LinkedListMiddle
    {
        LinkedList<string> values = new LinkedList<string>();

        public LinkedListMiddle()
        {
            values.AddLast("Dio");
            values.AddLast("Mik");
            values.AddLast("Nik");
            values.AddLast("ty");
            values.AddLast("oty");
            values.AddLast("pkk");
            values.AddLast("otr");
            values.AddLast("mor");
            values.AddLast("mtr");
        }

        public LinkedListNode<string>? FindMiddle()
        {
            if (values.Count == 0)
            {
                Console.WriteLine("This list is empty!");
                return null;
            }

            int index = 0;
            int middleIndex = values.Count / 2;

            LinkedListNode<string>? current = values.First;

            while(index < middleIndex && current != null)
            {
                current = current.Next;
                index++;
            }

            Console.WriteLine("Middle is: " + current!.Value);
            return current;
        }

        public LinkedListNode<string>? FindMiddleOptimal()
        {
            if (values.First == null)
                return null;

            LinkedListNode<string>? slow = values.First;
            LinkedListNode<string>? fast = values.First;

            while (fast != null && fast.Next != null)
            {
                slow = slow!.Next;
                fast = fast.Next.Next;
            }

            return slow;
        }
    }
}
