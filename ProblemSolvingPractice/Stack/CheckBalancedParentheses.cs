namespace ProblemSolvingPractice.Stack
{
    public class CheckBalancedParentheses
    {
        public bool IsBalancedParentheses(string input)
        {
            Stack<char> stack = new();
            foreach (var item in input)
            {
                if (item == '[' || item == '{' || item == '(')
                {
                    stack.Push(item);
                }
                
                if (item == ')' || item == '}' || item == ']')
                {
                    if (stack.Count < 1)
                        return false;

                    char top = stack.Peek();

                    if ((top == '(' && item == ')')
                        || (top == '{' && item == '}')
                        || (top == '[' && item == ']'))
                    {
                        stack.Pop();
                    }
                    else
                    {
                        return false;
                    }
                }
            }

            return stack.Count == 0;
        }
    }
}
