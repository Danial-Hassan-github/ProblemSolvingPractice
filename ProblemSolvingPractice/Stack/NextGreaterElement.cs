namespace ProblemSolvingPractice.Stack
{
    public class NextGreaterElement
    {
        public void NextGreater(List<int> values)
        {
            if (values.Count == 0)
                return;

            Stack<int> stack = new();
            List<int> result = Enumerable.Repeat(-1, values.Count).ToList();

            for (int i = 0; i < values.Count; i++)
            {
                while (stack.Count > 0 && values[i] > values[stack.Peek()])
                {
                    int index = stack.Pop();
                    result[index] = values[i];
                }

                stack.Push(i);
            }

            while (stack.Count > 0)
            {
                int index = stack.Pop();
                result[index] = -1;
            }

            foreach (int value in result)
                Console.WriteLine(value);
        }
    }
}
