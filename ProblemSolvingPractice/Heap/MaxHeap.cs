namespace ProblemSolvingPractice.Heap
{
    public class MaxHeap
    {
        private List<int> _heap = new();

        public int Count => _heap.Count;

        public void Insert(int value)
        {
            _heap.Add(value);

            int index = _heap.Count - 1;

            while (index > 0)
            {
                int parent = (index - 1) / 2;

                if (_heap[parent] >= _heap[index])
                    break;

                Swap(parent, index);
                index = parent;
            }
        }

        public int Peek()
        {
            if (_heap.Count == 0)
                return -1;

            return _heap[0];
        }

        public int ExtractMax()
        {
            if (_heap.Count == 0)
                return -1;

            int max = _heap[0];

            _heap[0] = _heap[^1];
            _heap.RemoveAt(_heap.Count - 1);

            int index = 0;

            while (true)
            {
                int left = index * 2 + 1;
                int right = index * 2 + 2;
                int largest = index;

                if (left < _heap.Count && _heap[left] > _heap[largest])
                    largest = left;

                if (right < _heap.Count && _heap[right] > _heap[largest])
                    largest = right;

                if (largest == index)
                    break;

                Swap(index, largest);
                index = largest;
            }

            return max;
        }

        private void Swap(int first, int second)
        {
            int temp = _heap[first];
            _heap[first] = _heap[second];
            _heap[second] = temp;
        }
    }
}