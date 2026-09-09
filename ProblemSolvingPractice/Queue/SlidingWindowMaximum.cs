namespace ProblemSolvingPractice.Queue
{
    public class SlidingWindowMaximum
    {
        public List<int> Maximums(int[] nums, int k)
        {
            List<int> result = new List<int>();
            LinkedList<int> queue = new LinkedList<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                while (queue.Count > 0 && queue.First.Value <= i - k)
                    queue.RemoveFirst();

                while (queue.Count > 0 && nums[queue.Last.Value] <= nums[i])
                    queue.RemoveLast();

                queue.AddLast(i);

                if (i >= k - 1)
                    result.Add(nums[queue.First.Value]);
            }

            return result;
        }
    }
}