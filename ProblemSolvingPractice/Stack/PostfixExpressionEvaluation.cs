namespace ProblemSolvingPractice.Stack
{
    public class PostfixExpressionEvaluation
    {
        public void Evaluate(List<char> expression)
        {
            Stack<double> ints = new Stack<double>();

            foreach (var item in expression)
            {
                if (item == '+' || item == '-' || item == '*'
                    || item == '/' || item == '%')
                {
                    if (ints.Count < 2)
                    {
                        Console.WriteLine("Invalid postfix expression.");
                        return;
                    }

                    double right = ints.Pop();
                    double left = ints.Pop();

                    if (item == '+')
                        ints.Push(left + right);
                    else if (item == '-')
                        ints.Push(left - right);
                    else if (item == '*')
                        ints.Push(left * right);
                    else if (item == '/')
                        ints.Push(left / right);
                    else if (item == '%')
                        ints.Push(left % right);

                }
                else if (double.TryParse(item.ToString(), out double number))
                {
                    ints.Push(number);
                }
            }

            if (ints.Count != 1)
            {
                Console.WriteLine("Invalid postfix expression.");
                return;
            }

            while (ints.Count > 0)
                Console.WriteLine(ints.Pop());
        }
    }
}
