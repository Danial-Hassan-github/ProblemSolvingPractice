namespace ProblemSolvingPractice.Hashing_LinkedList
{
    public class ReverseLinkedList
    {
        private Node<int> head;
        public ReverseLinkedList()
        {
            Node<int> a = new(0);
            Node<int> b = new(1);
            Node<int> c = new(2);   
            Node<int> d = new(3);
            Node<int> e = new(4);
            Node<int> f = new(5);
            Node<int> g = new(6);
            Node<int> h = new(7);  
            Node<int> i = new(8);
            Node<int> j = new(9);
            Node<int> k = new(10);

            a.Next = b;
            b.Next = c;
            c.Next = d;
            d.Next = e;
            e.Next = f;
            f.Next = g;
            g.Next = h;
            h.Next = i;
            i.Next = j;
            j.Next = k;

            head = a;
        }

        public Node<int>? ReverseList()
        {
            Node<int>? previous = null;
            Node<int>? current = head;

            while (current != null)
            {
                Node<int>? next = current.Next;
                current.Next = previous;
                previous = current;
                current = next;
            }

            while (previous != null)
            {
                Console.WriteLine(previous.Value);
                previous = previous.Next;
            }

            return previous;
        }
    }
}
