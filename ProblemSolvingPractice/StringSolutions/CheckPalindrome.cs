using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingPractice.StringSolutions
{
    public class CheckPalindrome
    {
        public bool IsPalindrome()
        {
            string str = "madam";
            int leftIndex = 0;
            int rightIndex = str.Length - 1;
            while (leftIndex < rightIndex)
            {
                if (str[leftIndex] != str[rightIndex])
                {
                    return false;
                }
                leftIndex++;
                rightIndex--;
            }
            return true;
        }
    }
}
