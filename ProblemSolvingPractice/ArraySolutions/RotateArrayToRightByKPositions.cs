using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingPractice.ArraySolutions
{
    public class RotateArrayToRightByKPositions
    {
        public int[] Rotate()
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int temp;
            int k = 3;
            k = k % arr.Length;
            while (k > 0)
            {
                for (int j = arr.Length - 1; j > 0 ; j--)
                {
                    temp = arr[j];
                    arr[j] = arr[j - 1];
                    arr[j - 1] = temp;
                }
                k--;
            }

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
            return arr;
        }
    }
}
