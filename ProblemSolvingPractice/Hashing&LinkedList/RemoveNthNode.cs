namespace ProblemSolvingPractice.Hashing_LinkedList
{
    public class RemoveNthNode
    {
        CustomLinkedList<string> head = new();
        public RemoveNthNode()
        {
            head.AddLast("Ali");
            head.AddLast("Dani");
            head.AddLast("Ahsan");
            head.AddLast("Farrukh");
        }
        public void RemoveNth(int index)
        {
            int counter = 0;
            Node<string> node = head.First;
            while (node != null)
            {
                if (counter == index)
                    head.Remove(node);
                node = node.Next;
                counter++;
            }
        }
    }
}
