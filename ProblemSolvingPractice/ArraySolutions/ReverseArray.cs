using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingPractice.ArraySolutions
{
    public class ReverseArray
    {
        int[] arr = new int[] {1,2,3,7,2,3,9,7,12,11,21,27};
        public int[] ReverseArr()
        {
            int rightIndex = arr.Length - 1;
            for (int i = 0; i < rightIndex; i++)
            {
                int temp = arr[i];
                arr[i] = arr[rightIndex];
                arr[rightIndex] = temp;
                rightIndex--;
            }
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
            return arr;
        }
    }
}
