namespace ProblemSolvingPractice.Hashing_LinkedList
{
    public class LinkedListsIntersection
    {
        Node<int> first;
        Node<int> second;
        Node<int> secondHead;
        Node<int> result = null;

        public LinkedListsIntersection()
        {
            Node<int> a = new Node<int>(1);
            Node<int> b = new Node<int>(2);
            Node<int> c = new Node<int>(3);
            Node<int> d = new Node<int>(4);

            a.Next = b;
            b.Next = c;
            c.Next = d;
            first = a;

            Node<int> e = new Node<int>(4);
            Node<int> f = new Node<int>(3);
            Node<int> g = new Node<int>(6);
            Node<int> h = new Node<int>(7);

            e.Next = f;
            f.Next = g;
            g.Next = h;
            second = e;
            secondHead = e;
        }

        public Node<int> Intersection()
        {
            Node<int> current = null;
            while (first != null)
            {
                while (second != null)
                {
                    if (first.Value == second.Value)
                    {
                        Node<int> newNode = new(first.Value);
                        if (result == null)
                        {
                            result = newNode;
                            current = newNode;
                        }
                        else
                        {
                            current.Next = newNode;
                            current = newNode;
                        }
                    }
                    second = second.Next;
                }
                second = secondHead;
                first = first.Next;
            }

            return result;
        }

        public Node<int>? IntersectionOptimal()
        {
            HashSet<int> values = new();

            Node<int>? current = first;

            while (current != null)
            {
                values.Add(current.Value);
                current = current.Next;
            }

            Node<int>? result = null;
            Node<int>? tail = null;

            current = second;

            while (current != null)
            {
                if (values.Contains(current.Value))
                {
                    Node<int> newNode = new(current.Value);

                    if (result == null)
                    {
                        result = newNode;
                        tail = newNode;
                    }
                    else
                    {
                        tail!.Next = newNode;
                        tail = newNode;
                    }
                }

                current = current.Next;
            }

            return result;
        }
    }
}
