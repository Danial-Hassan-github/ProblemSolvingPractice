using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingPractice.ArraySolutions
{
    public class MergeSortedArray
    {
        public int[] Merge()
        {
            int[] arr1 = new int[] { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20, 22 };
            int[] arr2 = new int[] { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21 };
            int[] result = new int[arr1.Length + arr2.Length];
            int pointer1 = 0;
            int pointer2 = 0;
            int resultPointer = 0;

            for (int i = 0; i < result.Length; i++)
            {
                if (pointer1 >= arr1.Length || pointer2 >= arr2.Length)
                {
                    resultPointer = i;
                    break;
                }
                if (arr2[pointer2] < arr1[pointer1])
                {
                    result[i] = arr2[pointer2];
                    pointer2++;
                }
                else
                {
                    result[i] = arr1[pointer1];
                    pointer1++;
                }
            }

            while (pointer1 < arr1.Length)
            {
                result[resultPointer] = arr1[pointer1];
                pointer1++;
                resultPointer++;
            }

            while (pointer2 < arr2.Length)
            {
                result[resultPointer] = arr2[pointer2];
                pointer2++;
                resultPointer++;
            }

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            return result;
        }
    }
}
