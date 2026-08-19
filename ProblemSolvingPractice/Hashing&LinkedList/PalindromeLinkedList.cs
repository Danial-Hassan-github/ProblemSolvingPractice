namespace ProblemSolvingPractice.Hashing_LinkedList
{
    public class PalindromeLinkedList
    {
        CustomLinkedList<string> head = new();

        public PalindromeLinkedList()
        {
            head.AddLast("A");
            head.AddLast("B");
            head.AddLast("C");
            head.AddLast("B");
            head.AddLast("A");
        }

        public bool CheckPalindrome()
        {
            Node<string> node = head.First;
            List<string> list = new List<string>();

            while (node != null)
            {
                list.Add(node.Value);
                node = node.Next;
            }

            node = head.First;
            int count = list.Count - 1;

            while (count > count/2)
            {
                if (node.Value == list[count])
                    node = node.Next;
                else
                    return false;
                count--;
            }

            return true;
        }
    }
}