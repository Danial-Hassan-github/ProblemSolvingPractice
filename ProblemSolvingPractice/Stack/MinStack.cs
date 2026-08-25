namespace ProblemSolvingPractice.Stack
{
    public class MinStack
    {
        public Stack<int> GetMinStack(List<int> ints)
        {
            Stack<int> mainStack = new Stack<int>();
            Stack<int> minStack = new Stack<int>();

            foreach (var current in ints)
            {
                mainStack.Push(current);

                if (minStack.Count == 0 || current <= minStack.Peek())
                {
                    minStack.Push(current);
                }
            }

            return minStack;
        }
    }
}
