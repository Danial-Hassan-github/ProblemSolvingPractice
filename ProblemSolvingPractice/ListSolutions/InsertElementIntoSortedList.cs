namespace ProblemSolvingPractice.ListSolutions
{
    public class InsertElementIntoSortedList
    {
        List<int> ints = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };

        public List<int> InsertIntoSorted(int num)
        {
            for (int i = 0; i < ints.Count; i++)
            {
                if (ints[i] >= num)
                {
                    ints.Insert(i, num);
                    return ints;
                }
            }

            ints.Add(num);
            return ints;
        }
    }
}
