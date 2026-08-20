using ProblemSolvingPractice.Hashing_LinkedList;

namespace ProblemSolvingPractice.Stack
{
    public class StackUsingLinkedList
    {
        private CustomLinkedList<int> stack = new();

        public int Push(int num)
        {
            stack.AddLast(num);
            return num;
        }

        public int Pop()
        {
            if (stack.IsEmpty())
            {
                Console.WriteLine("Stack is empty");
                return -1;
            }
            int last = stack.Last.Value;
            stack.RemoveLast();
            return last;
        }

        public void Display()
        {
            Console.WriteLine("###############");
            stack.Display();
            Console.WriteLine("###############");
        }
    }
}
