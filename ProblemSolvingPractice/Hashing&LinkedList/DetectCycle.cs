namespace ProblemSolvingPractice.Hashing_LinkedList
{
    public class DetectCycle
    {
        private Node<int> head;
        public DetectCycle()
        {
            Node<int> a = new(3);
            Node<int> b = new(5);
            Node<int> c = new(6);
            Node<int> d = new(2);

            a.Next = b;
            b.Next = c;
            c.Next = d;
            d.Next = b;

            head = a;
        }
        public void DetectLoop()
        {
            Node<int>? slow = head;
            Node<int>? fast = head;

            while (fast != null && fast.Next != null)
            {
                slow = slow!.Next;
                fast = fast.Next.Next;
                if (fast == slow)
                {
                    Console.WriteLine("Cycle detected on " + slow!.Value);
                    return;
                }
            }

            Console.WriteLine("No Cycle Detected!");
        }
    }
}
