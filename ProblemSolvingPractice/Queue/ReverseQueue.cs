namespace ProblemSolvingPractice.Queue
{
    public class ReverseQueue
    {
        Queue<int> ints = new Queue<int>();

        public ReverseQueue()
        {
            ints.Enqueue(0);
            ints.Enqueue(1);
            ints.Enqueue(2);
            ints.Enqueue(3);
            ints.Enqueue(4);
            ints.Enqueue(5);
        }

        public Queue<int> ReverseWithArray()
        {
            int count = ints.Count;
            int[] reverseArr = new int[ints.Count];

            while (count > 0)
            {
                int last = ints.Dequeue();
                reverseArr[count - 1] = last;
                count--;
            }

            while (count <= reverseArr.Length - 1)
            {
                ints.Enqueue(reverseArr[count]);
                count++;
            }

            return ints;
        }

        public Queue<int> ReverseWithStack()
        {
            Stack<int> stack = new Stack<int>();

            while (ints.Count > 0)
                stack.Push(ints.Dequeue());

            while (stack.Count > 0)
                ints.Enqueue(stack.Pop());

            return ints;
        }
    }
}
