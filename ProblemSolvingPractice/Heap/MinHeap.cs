namespace ProblemSolvingPractice.Heap
{
    public class MinHeap
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

                if (_heap[parent] <= _heap[index])
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

        public int ExtractMin()
        {
            if (_heap.Count == 0)
                return -1;

            int min = _heap[0];

            _heap[0] = _heap[^1];
            _heap.RemoveAt(_heap.Count - 1);

            int index = 0;

            while (true)
            {
                int left = index * 2 + 1;
                int right = index * 2 + 2;
                int smallest = index;

                if (left < _heap.Count && _heap[left] < _heap[smallest])
                    smallest = left;

                if (right < _heap.Count && _heap[right] < _heap[smallest])
                    smallest = right;

                if (smallest == index)
                    break;

                Swap(index, smallest);
                index = smallest;
            }

            return min;
        }

        private void Swap(int first, int second)
        {
            int temp = _heap[first];
            _heap[first] = _heap[second];
            _heap[second] = temp;
        }
    }
}