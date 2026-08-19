using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingPractice.ListSolutions
{
    public class ElementsInFirstListOnly
    {
        public int[] arr1 = new int[] {0,2,5,1,8,4,9,6,12,21,11,17,24};
        public int[] arr2 = new int[] {2,7,9,3,7,19,21,25,5,4,27,12};
        public int[] resultArr;
        int count = 0;
        public int[] ElementsInFirstArr()
        {
            resultArr = new int[arr1.Length];
            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = 0; j < arr2.Length; j++)
                {
                    if (arr1[i] == arr2[j])
                    {
                        break;
                    }
                    if (j == arr2.Length - 1)
                    {
                        resultArr[count] = arr1[i];
                        count++;
                    }
                }
            }

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(resultArr[i]);
            }
            return resultArr;
        }
    }
}
