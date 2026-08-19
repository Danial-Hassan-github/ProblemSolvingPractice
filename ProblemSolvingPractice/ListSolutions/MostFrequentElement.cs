namespace ProblemSolvingPractice.ListSolutions
{
    public class MostFrequentElement
    {
        List<int> elements = new List<int> { 1, 2, 3, 7, 8, 9, 3, 7, 1, 7 };

        public int? MostFrequent()
        {
            if (elements.Count == 0)
            {
                return null;
            }
            int mostFrequent = elements[0];
            int max = 0;

            for (int i = 0; i < elements.Count; i++)
            {
                int counter = 0;
                for (int j = 0; j < elements.Count; j++)
                {
                    if (elements[i] == elements[j])
                    {
                        counter++;
                    }
                }

                if (counter > max)
                {
                    max = counter;
                    mostFrequent = elements[i];
                }
            }

            Console.WriteLine(mostFrequent);

            return mostFrequent;
        }
    }
}
