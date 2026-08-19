using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingPractice.StringSolutions
{
    public class CheckAnagram
    {
        public bool IsAnagram()
        {
            string str1 = "listen".ToLower();
            string str2 = "silent".ToLower();
            char[] chars = str2.ToCharArray();

            if (str1.Length != str2.Length)
            {
                return false;
            }

            if (str1 == str2)
            {
                return true;
            }

            for (int i = 0; i < str1.Length; i++)
            {
                for (int j = 0; j < chars.Length; j++)
                {
                    if (str1[i] == chars[j])
                    {
                        chars[j] = '.';
                        break;
                    }
                    if (j == chars.Length - 1)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
