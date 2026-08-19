using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingPractice.ArraySolutions
{
    public class MoveZerosToEnd
    {
        public int[] MoveZeros()
        {
            int[] arr = new int[] { 0, 2, 1, 0, 7, 9, 0, 11, 3, 9, 0, 6, 21, 13 };
            int swapIndex;
            swapIndex = arr.Length - 1;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] == 0 && i < swapIndex)
                {
                    arr[i] = arr[swapIndex];
                    arr[swapIndex] = 0;
                    swapIndex--;
                }
            }
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
            return arr;
        }

        public int[] MoveZerosKeepOrder()
        {
            int[] arr = new int[] { 0, 2, 1, 0, 7, 9, 0, 11, 3, 9, 0, 6, 21, 13 };
            int left = 0;
            int right = 0;
            while (left < arr.Length)
            {
                if (arr[left] != 0)
                {
                    if (left != right)
                    {
                        arr[right] = arr[left];
                    }
                    right++;
                }
                left++;
            }
            while (right < arr.Length)
            {
                arr[right] = 0;
                right++;
            }
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
            return arr;
        }
    }
}
