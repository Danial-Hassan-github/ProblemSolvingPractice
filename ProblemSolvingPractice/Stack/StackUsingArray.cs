namespace ProblemSolvingPractice.Stack
{
    public class StackUsingArray
    {
        private int[] arr = new int[4];
        int currentIndex = 0;

        public int Push(int num)
        {
            try
            {
                if (currentIndex >= arr.Length)
                    throw new InvalidOperationException("Memory Full");

                arr[currentIndex] = num;
                currentIndex++;
                return num;
            } catch (InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
                return -1;
            }
            
        }

        public int Pop()
        {
            try
            {
                if (currentIndex == 0)
                    throw new InvalidOperationException("No Data");

                currentIndex--;
                int value = arr[currentIndex];
                arr[currentIndex] = 00;

                return value;
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
                return -1;
            }
        }

        public void Display()
        {
            Console.WriteLine("###############");
            for (int i = 0; i < currentIndex; i++)
                Console.WriteLine(arr[i]);
            Console.WriteLine("###############");
        }
    }
}
