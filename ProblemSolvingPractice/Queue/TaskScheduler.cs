namespace ProblemSolvingPractice.Queue
{
    public class TaskScheduler
    {
        private Queue<string> _tasks = new Queue<string>();

        public void AddTask(string task)
        {
            _tasks.Enqueue(task);
        }

        public string? ProcessNextTask()
        {
            if (_tasks.Count == 0)
                return null;

            return _tasks.Dequeue();
        }

        public string? PeekNextTask()
        {
            if (_tasks.Count == 0)
                return null;

            return _tasks.Peek();
        }

        public int PendingTasks()
        {
            return _tasks.Count;
        }

        public bool HasPendingTasks()
        {
            return _tasks.Count > 0;
        }
    }
}