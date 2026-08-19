using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingPractice.StringSolutions
{
    public class FirstNonRepeatingCharacter
    {
        public char FindFirstNonRepeating()
        {
            string str = "Myself Diana Ali. What about you Mr.?".ToLower();

            if (string.IsNullOrEmpty(str))
            {
                Console.WriteLine("String is empty!");
                return '\0';
            }

            for (int i = 0; i < str.Length; i++)
            {
                for (int j = 0; j < str.Length ; j++)
                {
                    if (str[i] == str[j] && i != j)
                    {
                        break;
                    }
                    if (j == str.Length - 1)
                    {
                        return str[i];
                    }
                }
            }

            return '\0';
        }
    }
}
