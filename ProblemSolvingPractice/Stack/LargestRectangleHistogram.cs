namespace ProblemSolvingPractice.Stack
{
    public class LargestRectangleHistogram
    {
        public int FindLargestRectangle(List<int> bars)
        {
            Stack<int> stack = new();
            int maxArea = 0;

            for (int i = 0; i <= bars.Count; i++)
            {
                int currentHeight = i == bars.Count ? 0 : bars[i];

                while (stack.Count > 0 && currentHeight < bars[stack.Peek()])
                {
                    int heightIndex = stack.Pop();
                    int height = bars[heightIndex];

                    int width;

                    if (stack.Count == 0)
                        width = i;
                    else
                        width = i - stack.Peek() - 1;

                    int area = height * width;

                    maxArea = Math.Max(maxArea, area);
                }

                stack.Push(i);
            }

            return maxArea;
        }
    }
}