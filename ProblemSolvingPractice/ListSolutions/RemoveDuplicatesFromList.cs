namespace ProblemSolvingPractice.ListSolutions
{
    public class RemoveDuplicatesFromList
    {
        List<char> list = new List<char> {'a','b', 'c', 'f', 'n', 'b', 'g', 'f'};

        public List<char> RemoveDuplicates()
        {
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = i+1; j < list.Count; j++)
                {
                    if(list[i] == list[j])
                    {
                        list.RemoveAt(j);
                        j--;
                    }
                }
            }

            foreach (char c in list)
            {
                Console.WriteLine(c);
            }
            return list;
        }

    }
}
