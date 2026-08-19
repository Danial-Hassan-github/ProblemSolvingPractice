using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingPractice.ListSolutions
{
    public class ReverseList
    {
        public List<int> Reverse()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int temp;
            int left = 0;
            int right = numbers.Count - 1;
            while (left < right)
            {
                temp = numbers[left];
                numbers[left] = numbers[right];
                numbers[right] = temp;
                left++;
                right--;
            }

            // numbers.Reverse();

            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }

            return numbers;
        }
    }
}
