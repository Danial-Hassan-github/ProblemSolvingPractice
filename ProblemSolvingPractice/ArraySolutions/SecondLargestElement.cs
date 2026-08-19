using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingPractice.ArraySolutions
{
    public class SecondLargestElement
    {
        public int FindSecondLargest()
        {
            int[] arr = new int[] { 2, 4, 6, 8, 10, 12, 14, 1, 16, 26, 20, 22 };
            int largest;
            int secondLargest;

            if (arr[1] > arr[0])
            {
                largest = arr[1];
                secondLargest = arr[0];
            }
            else
            {
                largest = arr[0];
                secondLargest = arr[1];
            }

            for (int i = 2; i < arr.Length; i++)
            {
                if (arr[i] > largest)
                {
                    secondLargest = largest;
                    largest = arr[i];
                }
                else if (arr[i] > secondLargest)
                {
                    secondLargest = arr[i];
                }
            }

            Console.WriteLine(secondLargest);

            return secondLargest;
        }
    }
}
