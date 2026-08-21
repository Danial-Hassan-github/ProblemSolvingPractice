using System.Text;

namespace ProblemSolvingPractice.Stack
{
    public class ReverseStringWithStack
    {
        public string Reverse(string s)
        {
            Stack<char> stack = new Stack<char>();
            for (int i = 0; i < s.Length; i++)
            {
                stack.Push(s[i]);
            }
            
            StringBuilder result = new();

            while (stack.Count > 0)
            {
                result.Append(stack.Pop());
            }
            return result.ToString();
        }
    }
}
