namespace ProblemSolvingPractice.Hashing_LinkedList
{
    public class CustomLinkedList<T>
    {
        private Node<T>? head;
        private Node<T>? tail;
        public Node<T>? First { get { return head; } }
        public Node<T>? Last { get { return tail; } }

        public void Display()
        {
            Node<T>? current = head;

            while (current != null)
            {
                Console.WriteLine(current.Value);
                current = current.Next;
            }
        }

        public bool IsEmpty()
        {
            if (head == null)
                return true;
            return false;
        }

        public void AddFirst(T Value)
        {
            Node<T> node = new(Value);
            if (head == null)
            {
                head = tail = node;
                return;
            }
            node.Next = head;
            head = node;
        }

        public void AddLast(T Value)
        {
            Node<T> node = new(Value);
            if (head == null)
            {
                head = tail = node;
                return;
            }
            tail!.Next = node;
            tail = node;
        }

        public void Remove(Node<T> node)
        {
            if (head == null)
                return;

            if (head == node)
            {
                RemoveFirst();
                return;
            }

            if (node == tail)
            {
                RemoveLast();
                return;
            }

            Node<T> prev = head;
            Node<T> next = prev.Next;

            while (next != null)
            {
                if (next == node)
                {
                    prev.Next = next.Next;
                    break;
                }

                prev = prev.Next;
                next = next.Next;
            }
        }

        public void RemoveFirst()
        {
            if (head == null)
                return;
            head = head.Next;
            if (head == null)
                tail = null;
        }

        public void RemoveLast()
        {
            if (head == null)
                return;

            if (head == tail)
            {
                head = tail = null;
                return;
            }

            Node<T> current = head;

            while (current.Next != tail)
            {
                current = current.Next!;
            }

            current.Next = null;
            tail = current;
        }
    }
}
