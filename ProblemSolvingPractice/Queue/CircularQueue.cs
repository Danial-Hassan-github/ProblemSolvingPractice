namespace ProblemSolvingPractice.Queue
{
    public class CircularQueue<T>
    {
        private T[] queue;
        private int frontIndex = -1;
        private int rearIndex = -1;
        private int count = 0;

        public CircularQueue(int capacity)
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
            if (count == queue.Length)
            {
                Console.WriteLine("Queue is full");
                return default;
            }

            if (rearIndex == -1)
                rearIndex = 0;

            queue[rearIndex] = item;
            rearIndex++;

            if (rearIndex == queue.Length)
                rearIndex = 0;

            if (frontIndex == -1)
                frontIndex = 0;
            count++;

            return item;
        }

        public T? Dequeue()
        {
            if (count == 0)
            {
                Console.WriteLine("Queue is empty");
                return default;
            }

            T item = queue[frontIndex];
            queue[frontIndex] = default;
            frontIndex++;

            if (frontIndex == queue.Length)
                frontIndex = 0;
            count--;

            if (count == 0)
            {
                frontIndex = -1;
                rearIndex = -1;
            }

            return item;
        }
    }
}
