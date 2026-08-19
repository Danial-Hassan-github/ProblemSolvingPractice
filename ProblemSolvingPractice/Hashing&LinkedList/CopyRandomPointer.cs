namespace ProblemSolvingPractice.Hashing_LinkedList
{
    public class CopyRandomPointer
    {
        NodeWithRandom head;

        public CopyRandomPointer()
        {
            NodeWithRandom node1 = new NodeWithRandom(7);
            NodeWithRandom node2 = new NodeWithRandom(13);
            NodeWithRandom node3 = new NodeWithRandom(11);
            NodeWithRandom node4 = new NodeWithRandom(10);
            NodeWithRandom node5 = new NodeWithRandom(1);

            // next pointers
            node1.next = node2;
            node2.next = node3;
            node3.next = node4;
            node4.next = node5;

            // random pointers
            node1.random = null;
            node2.random = node1;
            node3.random = node5;
            node4.random = node3;
            node5.random = node1;

            // Head of the list
            head = node1;
        }

        public NodeWithRandom CopyRandomList()
        {
            if (head == null)
                return null;

            Dictionary<NodeWithRandom, NodeWithRandom> map =
                new Dictionary<NodeWithRandom, NodeWithRandom>();

            NodeWithRandom current = head;

            while (current != null)
            {
                map[current] = new NodeWithRandom(current.val);
                current = current.next;
            }

            current = head;

            while (current != null)
            {
                NodeWithRandom copy = map[current];

                copy.next = current.next == null
                    ? null
                    : map[current.next];

                copy.random = current.random == null
                    ? null
                    : map[current.random];

                current = current.next;
            }

            return map[head];
        }
    }
}
