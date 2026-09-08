namespace ProblemSolvingPractice.Queue
{
    public class StackUsingTwoQueues<T>
    {
        Queue<T> queue1 = new Queue<T>();
        Queue<T> queue2 = new Queue<T>();

        public void Push(T val)
        {
            queue2.Enqueue(val);

            while (queue1.Count > 0)
                queue2.Enqueue(queue1.Dequeue());

            Queue<T> temp = queue1;
            queue1 = queue2;
            queue2 = temp;
        }

        public T? Pop()
        {
            if (queue1.Count == 0)
                return default;

            return queue1.Dequeue();
        }
    }
}
