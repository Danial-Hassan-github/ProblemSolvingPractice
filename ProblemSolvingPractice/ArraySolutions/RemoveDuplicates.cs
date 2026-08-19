using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingPractice.ArraySolutions
{
    public class RemoveDuplicates
    {
        public HashSet<int> RemoveDup()
        {
            int[] arr = new int[] {7,9,21,4,7,19,2,11,4,16,12,28,2,9};
            HashSet<int> set = new HashSet<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (!set.Contains(arr[i]))
                {
                    set.Add(arr[i]);
                }
            }

            foreach (var item in set)
            {
                Console.WriteLine(item);
            }

            return set;
        }

        public int[] RemoveDupArr()
        {
            int[] arr = new int[] { 7, 9, 21, 11, 4, 7, 19, 2, 11, 11, 4, 16, 12, 28, 2, 9 };
            int length = arr.Length;

            for (int i = 0; i < length; i++)
            {
                for (int j = i+1; j < length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        for (int k = j; k < length - 1; k++)
                        {
                            arr[k] = arr[k + 1];
                        }
                        j--;
                        length--;
                    }
                }
            }

            for (int i = 0; i < length; i++)
            {
                Console.WriteLine(arr[i]);
            }

            return arr;
        }

        public int[] RemoveDupUsingNewArr()
        {
            int[] arr = new int[] { 7, 9, 21, 11, 4, 7, 19, 2, 11, 11, 4, 16, 12, 28, 2, 9 };
            int[] result = new int[arr.Length];
            int count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                bool isFound = false;
                for (int j = 0; j < count; j++)
                {
                    if (arr[i] == result[j])
                    {
                        isFound = true;
                        break;
                    }
                }

                if (!isFound)
                {
                    result[count] = arr[i];
                    count++;
                    isFound = false;
                }
            }

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(result[i]);
            }

            return result;
        }
    }
}
