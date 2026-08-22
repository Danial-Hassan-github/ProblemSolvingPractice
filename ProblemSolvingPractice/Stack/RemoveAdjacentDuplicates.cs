namespace ProblemSolvingPractice.Stack
{
    public class RemoveAdjacentDuplicates
    {
        public void RemoveDuplicates(List<int> ls)
        {
            Stack<int> stack = new Stack<int>();
            List<int> result = new List<int>();

            foreach (int i in ls)
            {
                if (stack.Count == 0 || stack.Peek() != i)
                    stack.Push(i);
            }

            result.AddRange(stack);
            result.Reverse();

            foreach (var item in result)
                Console.WriteLine(item);
        }
    }
}
