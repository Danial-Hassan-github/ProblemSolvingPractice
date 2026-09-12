namespace ProblemSolvingPractice.Heap
{
    public class InsertIntoHeap
    {
        public void Insert(List<int> heap, int value)
        {
            heap.Add(value);

            int index = heap.Count - 1;

            while (index > 0)
            {
                int parent = (index - 1) / 2;

                if (heap[parent] <= heap[index])
                    break;

                int temp = heap[parent];
                heap[parent] = heap[index];
                heap[index] = temp;

                index = parent;
            }
        }
    }
}
