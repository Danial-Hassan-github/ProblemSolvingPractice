using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingPractice.ArraySolutions
{
    public class PairsEqualsTargetSum
    {
        public void EqualsTargetSum()
        {
            int[] arr = new int[] { 8, 1, 3, 4, 6, 3, 9, 2, 31, 0, 11, 5, 27 };
            int targetSum = 9;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i+1; j < arr.Length; j++)
                {
                    if (arr[i] + arr[j] == targetSum)
                    {
                        Console.WriteLine("Pair: " + arr[i] + "+" + arr[j]);
                    }
                }
            }
        }
    }
}
