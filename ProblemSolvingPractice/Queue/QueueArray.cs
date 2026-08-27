namespace ProblemSolvingPractice.Queue
{
    public class QueueArray<T>
    {
        private T[] queue;
        private int currentIndex = 0;

        public QueueArray(int capacity)
        {
            if (capacity <= 0)
            {
                Console.WriteLine("Invalid capacity. Default capacity of 5 will be used.");
                capacity = 5;
            }
            queue = new T[capacity];
        }

        public T? Enqueue(T item)
        {
            if (currentIndex >= queue.Length)
            {
                Console.WriteLine("Queue is full");
                return default;
            }
            queue[currentIndex] = item;
            currentIndex++;

            return item;
        }

        public T? Dequeue()
        {
            if (currentIndex == 0)
            {
                Console.WriteLine("Queue is empty");
                return default;
            }
            T item = queue[0];

            for (int i = 0; i < currentIndex - 1; i++)
                queue[i] = queue[i + 1];
            currentIndex--;
            queue[currentIndex] = default;
            
            return item;
        }

        public T? Peek()
        {
            if (currentIndex == 0)
            {
                Console.WriteLine("Queue is empty");
                return default;
            }
            return queue[0];
        }

        public void Clear()
        {
            for (int i = 0; i < currentIndex; i++)
                queue[i] = default;
            currentIndex = 0;
        }

        public int Size()
        {
            return currentIndex;
        }

        public bool IsEmpty()
        {
            return currentIndex == 0;
        }
    }
}
