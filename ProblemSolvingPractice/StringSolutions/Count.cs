namespace ProblemSolvingPractice.StringSolutions
{
    public class Count
    {
        public void CountCharTypes(string str)
        {
            int vowelCount = 0;
            int consonantCount = 0;
            int digitCount = 0;
            int specialCharCount = 0;

            for (int i = 0; i < str.Length; i++)
            {
                char c = str[i];

                if (c == 'a' || c == 'e' || c == 'i' ||
                    c == 'o' || c == 'u' ||
                    c == 'A' || c == 'E' || c == 'I' ||
                    c == 'O' || c == 'U')
                {
                    vowelCount++;
                }
                else if (c >= '0' && c <= '9')
                {
                    digitCount++;
                }
                else if ((c >= 'a' && c <= 'z') ||
                         (c >= 'A' && c <= 'Z'))
                {
                    consonantCount++;
                }
                else
                {
                    specialCharCount++;
                }
            }

            Console.WriteLine($"Vowels: {vowelCount}");
            Console.WriteLine($"Consonants: {consonantCount}");
            Console.WriteLine($"Digits: {digitCount}");
            Console.WriteLine($"Special Characters: {specialCharCount}");
        }
    }
}
