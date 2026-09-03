namespace ProblemSolvingPractice.Queue
{
    public class FirstNon_RepeatingCharacter
    {
        public char NonRepeatingChar(string str)
        {
            Queue<char> chars = new Queue<char>();
            Dictionary<char, int> charsWithFrequency = new Dictionary<char, int>();

            if (str.Length == 0)
                return '\0';

            foreach (var item in str)
            {
                if (charsWithFrequency.ContainsKey(item))
                    charsWithFrequency[item]++;
                else
                    charsWithFrequency[item] = 1;
                chars.Enqueue(item);
            }

            while (chars.Count > 0)
            {
                char c = chars.Dequeue();

                if (charsWithFrequency[c] == 1)
                    return c;
            }

            return '\0';
        }
    }
}
