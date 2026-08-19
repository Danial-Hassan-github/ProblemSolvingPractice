namespace ProblemSolvingPractice.ListSolutions
{
    public class FindMinMax
    {
        public (int? min,int? max) FindMinAndMax()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 0 };

            if (numbers.Count == 0)
            {
                Console.WriteLine("List is empty!");
                return (null, null);
            }

            int min = numbers[0];
            int max = numbers[0];

            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
            } 
            Console.WriteLine("Min is: " + min + "\nMax is: " + max);
            return (min, max);
        }
    }
}
