namespace ProblemSolvingPractice.Hashing_LinkedList
{
    public class DesignBrowserHistory
    {
        LinkedList<string> list = new LinkedList<string>();
        LinkedListNode<string> current = null;
        public void Visit(string query)
        {
            current = list.AddLast(query);
        }

        public void MoveBack()
        {
            if (current != null)
                current = current.Previous;
        }

        public void MoveForward()
        {
            if (current == null)
                return;
            if (current.Next != null)
                current = current.Next;
        }
    }
}
