using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingPractice.StringSolutions
{
    public class ReverseString
    {
        public char[] Reverse()
        {
            string str = "Hello dear";
            char[] chars = str.ToCharArray();
            char temp;
            int left = 0;
            int right = str.Length - 1;
            while (left < right)
            {
                temp = chars[left];
                chars[left] = chars[right];
                chars[right] = temp;
                left++;
                right--;
            }

            foreach (char c in chars)
            {
                Console.Write(c);
            }

            return chars;
        }
    }
}
