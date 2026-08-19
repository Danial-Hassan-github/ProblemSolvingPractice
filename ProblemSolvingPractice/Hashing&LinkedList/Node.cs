namespace ProblemSolvingPractice.Hashing_LinkedList
{
    public class Node<T>
    {
        public T Value;
        public Node<T>? Next = null;

        public Node(T Value)
        {
            this.Value = Value;
        }
    }
}
