using ProblemSolvingPractice.Hashing_LinkedList;

namespace ProblemSolvingPractice.Queue
{
    public class QueueLinkedList<T>
    {
        private Node<T>? head;
        private Node<T>? tail;
        private int count = 0;
        public T? Enqueue(T item)
        {
            Node<T> newNode = new Node<T>(item);
            if (head == null)
                head = tail = newNode;
            else
            {
                tail!.Next = newNode;
                tail = newNode;
            }
            count++;
            return tail.Value;
        }

        public T? Dequeue()
        {
            if (head == null)
                return default;

            Node<T> deletedNode = head;
            head = head.Next;

            if (head == null)
                tail = null;
            count--;
            return deletedNode.Value;
        }

        public T? Peek()
        {
            if (head == null)
                return default;
            return head.Value;
        }

        public bool IsEmpty()
        {
            return head == null;
        }

        public void Clear()
        {
            head = tail = null;
            count = 0;
        }

        public int Size()
        {
            return count;
        }
    }
}
