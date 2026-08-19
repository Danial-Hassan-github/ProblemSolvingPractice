namespace ProblemSolvingPractice.Hashing_LinkedList
{
    public class MergeSortedLinkedLists
    {
        private Node<int> firstListHead;
        private Node<int> secondListHead;

        public MergeSortedLinkedLists()
        {
            Node<int>? current = null;
            for (int i = 0; i < 10; i+=2)
            {
                Node<int> newNode = new(i);
                if (firstListHead == null)
                {
                    firstListHead = newNode;
                    current = newNode;
                    continue;
                }
                current!.Next = newNode;
                current = newNode;
            }

            current = null;
            for (int i = 1; i < 10; i+=2)
            {
                Node<int> newNode = new(i);
                if (secondListHead == null)
                {
                    secondListHead = newNode;
                    current = newNode;
                    continue;
                }
                current!.Next = newNode;
                current = newNode;
            }
        }

        public void MergeSorted()
        {
            Node<int> sorted = null;
            Node<int> sortedHead = null;

            while (firstListHead != null && secondListHead != null)
            {
                Node<int> current;
                if (firstListHead.Value < secondListHead.Value)
                {
                    current = firstListHead;
                    firstListHead = firstListHead.Next;
                }
                else
                {
                    current = secondListHead;
                    secondListHead = secondListHead.Next;
                }

                if (sortedHead == null)
                {
                    sortedHead = current;
                }
                else
                {
                    sorted.Next = current;
                }

                sorted = current;
            }

            sorted.Next = firstListHead ?? secondListHead;

            while (sortedHead != null)
            {
                Console.WriteLine(sortedHead.Value);
                sortedHead = sortedHead.Next;
            }
        }
    }
}
