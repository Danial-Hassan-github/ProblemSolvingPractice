using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingPractice.ArraySolutions
{
    public class SecondSmallestElement
    {
        public int FindSecondSmallest()
        {
            int[] arr = new int[] { 2, 4, 6, 8, 10, 12, 14, 1, 16, 18, 20, 22 };
            int smallest;
            int secondSmallest;

            if (arr[1] < arr[0])
            {
                smallest = arr[1];
                secondSmallest = arr[0];
            }
            else
            {
                smallest = arr[0];
                secondSmallest = arr[1];
            }

            for (int i = 2; i < arr.Length; i++)
            {
                if (arr[i] < smallest)
                {
                    secondSmallest = smallest;
                    smallest = arr[i];
                }else if (arr[i] < secondSmallest)
                {
                    secondSmallest = arr[i];
                }
            }

            Console.WriteLine(secondSmallest);

            return secondSmallest;
        }
    }
}
