namespace ProblemSolvingPractice.StringSolutions
{
    public class HighestFrequencyCharacter
    {
        public void HighestFrequencyChar(string str)
        {
            Dictionary<char, int> charFrequency = new Dictionary<char, int>();
            for (int i = 0; i < str.Length; i++)
            {
                if (charFrequency.ContainsKey(str[i]))
                {
                    charFrequency[str[i]]++;
                }
                else
                {
                    charFrequency[str[i]] = 1;
                }
            }

            int max = 0;
            char highestFrequencyChar = '\0';

            foreach (var item in charFrequency)
            {
                if (item.Value > max)
                {
                    highestFrequencyChar = item.Key;
                    max = item.Value;
                }
            }

            Console.WriteLine(highestFrequencyChar);
        }
    }
}
