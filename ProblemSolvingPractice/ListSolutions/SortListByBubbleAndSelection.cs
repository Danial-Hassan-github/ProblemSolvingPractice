namespace ProblemSolvingPractice.ListSolutions
{
    public class SortListByBubbleAndSelection
    {
        // Compare adjacent elements and swap them if they are in the wrong order.
        // After each pass, the largest unsorted element moves to the end.
        public void SortBubble(List<int> values)
        {
            for (int i = 0; i < values.Count; i++)
            {
                bool swapped = false;
                for (int j = 0; j < values.Count - i - 1; j++)
                {
                    if (values[j] > values[j+1])
                    {
                        int temp = values[j];
                        values[j] = values[j+1];
                        values[j+1] = temp;
                        swapped = true;
                    }
                }
                if (!swapped)
                    break;
            }

            foreach (var item in values)
            {
                Console.WriteLine(item);
            }
        }

        // Find the smallest element in the unsorted portion and swap it with the first unsorted element.
        // After each pass, one smallest element is placed in its correct position.
        public void SortSelection(List<int> values)
        {
            for (int i = 0; i < values.Count; i++)
            {
                int currentMinimumIndex = i;

                for (int j = i + 1; j < values.Count; j++)
                {
                    if (values[j] < values[currentMinimumIndex])
                        currentMinimumIndex = j;
                }

                int temp = values[i];
                values[i] = values[currentMinimumIndex];
                values[currentMinimumIndex] = temp;
            }

            foreach (var item in values)
            {
                Console.WriteLine(item);
            }
        }

        public string ValidatePin()
        {
            Console.Write("Enter Pin: ");
            string? pin = Console.ReadLine();
            if(pin == "00000")
                return "Approved";
            return "Failed";
        }
    }
}
