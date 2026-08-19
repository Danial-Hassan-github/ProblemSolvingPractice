using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingPractice.ArraySolutions
{
    public class LargestElement
    {
        public int FindLargest()
        {
            int[] arr = new int[] { 1, 2, 3, 7, 2, 3, 9, 7, 31, 12, 11, 21, 27 };
            int result = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > result)
                {
                    result = arr[i];
                }
            }
            Console.WriteLine(result);
            return result;
        }
    }
}
