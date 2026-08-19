using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingPractice.ArraySolutions
{
    public class SmallestElement
    {
        public int FindSmallest()
        {
            int[] arr = new int[] { 8, 6, 3, 7, 2, 3, 9, 7, 12, 11, 21, 27 };
            int smallest = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] <  smallest)
                {
                    smallest = arr[i];
                }
            }
            Console.WriteLine(smallest);
            return smallest;
        }
    }
}
