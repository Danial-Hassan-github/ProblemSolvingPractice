namespace ProblemSolvingPractice.Queue
{
    public class QueueUsingTwoStacks<T>
    {
        Stack<T> stack1 = new Stack<T>();
        Stack<T> stack2 = new Stack<T>();

        public void Enqueue(T val)
        {
            stack1.Push(val);
        }

        public T? Dequeue()
        {
            if (stack1.Count == 0 && stack2.Count == 0)
                return default;

            if (stack2.Count == 0)
                while (stack1.Count > 0)
                    stack2.Push(stack1.Pop());

            return stack2.Pop();
        }
    }
}
