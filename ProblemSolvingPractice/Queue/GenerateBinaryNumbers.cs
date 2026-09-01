namespace ProblemSolvingPractice.Queue
{
    public class GenerateBinaryNumbers
    {
        public Queue<string> GenerateBinary(int toNum)
        {
            Queue<string> binaries = new Queue<string>();
            Queue<string> queue = new Queue<string>();

            if (toNum <= 0)
                return binaries;

            queue.Enqueue("1");

            for (int i = 0; i < toNum; i++)
            {
                string current = queue.Dequeue();

                binaries.Enqueue(current);

                queue.Enqueue(current + "0");
                queue.Enqueue(current + "1");
            }


            return binaries;
        }
    }
}
