using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingPractice.ListSolutions
{
    public class RemoveEvenNumbers
    {
        public void RemoveEven()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //for (int i = 0; i < numbers.Count; i++)
            //{
            //    if (numbers[i]%2 != 0)
            //    {
            //        numbers.Remove(numbers[i]);
            //        i--;
            //    }
            //}

            numbers.RemoveAll(n => n % 2 == 0);

            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
        }
    }
}
