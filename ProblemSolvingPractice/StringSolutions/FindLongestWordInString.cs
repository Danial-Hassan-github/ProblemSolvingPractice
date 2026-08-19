using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingPractice.StringSolutions
{
    public class FindLongestWordInString
    {
        public StringBuilder FindLongest()
        {
            string str = "Hello, Dear Manager, How are you??";
            StringBuilder longestWord = new StringBuilder();
            StringBuilder prevLongestWord = new StringBuilder();

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != ' ')
                {
                    longestWord.Append(str[i]);
                    if (i != str.Length - 1)
                    {
                        continue;
                    }
                }
                if (longestWord.Length > prevLongestWord.Length)
                {
                    prevLongestWord.Clear();
                    prevLongestWord.Append(longestWord);
                }
                longestWord.Clear();
            }

            return prevLongestWord;
        }
    }
}
