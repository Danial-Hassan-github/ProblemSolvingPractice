namespace ProblemSolvingPractice.Hashing_LinkedList
{
    public class PartitionLinkedList
    {
        CustomLinkedList<int> values = new CustomLinkedList<int>();

        public PartitionLinkedList()
        {
            values.AddLast(27);
            values.AddLast(4);
            values.AddLast(91);
            values.AddLast(13);
            values.AddLast(56);
            values.AddLast(8);
            values.AddLast(72);
            values.AddLast(39);
            values.AddLast(15);
            values.AddLast(60);
            values.AddLast(2);
            values.AddLast(48);
        }

        public void MakePartition(int value)
        {
            Node<int>? leftHead = null;
            Node<int>? left = null;

            Node<int>? right = null;
            Node<int>? rightHead = null;

            Node<int>? current = values.First;

            while (current != null)
            {
                if (current.Value >= value)
                {
                    if (rightHead == null)
                        rightHead = right = new(current.Value);
                    else
                    {
                        right!.Next = new(current.Value);
                        right = right.Next;
                    }
                        
                }
                else
                {
                    if (leftHead == null)
                        leftHead = left = new(current.Value);
                    else
                    {
                        left!.Next = new(current.Value);
                        left = left.Next;
                    }
                }
                current = current!.Next;
            }

            if (left != null)
                left.Next = rightHead;
            else
                leftHead = rightHead;

            while (leftHead != null)
            {
                Console.WriteLine(leftHead.Value);
                leftHead = leftHead.Next;
            }
        }

        public void MakePartitionOptimal(int value)
        {
            Node<int>? leftHead = null;
            Node<int>? left = null;

            Node<int>? rightHead = null;
            Node<int>? right = null;

            Node<int>? current = values.First;

            while (current != null)
            {
                Node<int>? next = current.Next;
                current.Next = null;

                if (current.Value < value)
                {
                    if (leftHead == null)
                        leftHead = left = current;
                    else
                    {
                        left!.Next = current;
                        left = current;
                    }
                }
                else
                {
                    if (rightHead == null)
                        rightHead = right = current;
                    else
                    {
                        right!.Next = current;
                        right = current;
                    }
                }

                current = next;
            }

            if (left == null)
                leftHead = rightHead;
            else
                left.Next = rightHead;

            current = leftHead;

            while (current != null)
            {
                Console.WriteLine(current.Value);
                current = current.Next;
            }
        }
    }
}
