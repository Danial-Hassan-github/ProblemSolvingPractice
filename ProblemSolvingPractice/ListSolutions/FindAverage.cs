namespace ProblemSolvingPractice.ListSolutions
{
    public class FindAverage
    {
        public float Average()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int sum = 0;
            float average;

            if (numbers.Count == 0)
            {
                return 0;
            }

            foreach (int i in numbers)
            {
                sum += i;
            }

            // numbers.Average();

            average = (float)sum / numbers.Count;
            Console.WriteLine(average);
            return average;
        }
    }
}
