namespace ProblemSolvingPractice.ListSolutions
{
    public class FindIntersection
    {
        List<char> chars_first = new List<char> {'w', 'n', 'f', 'j', 'q', 'l', 'f', 'k', 'i', 'h' };
        List<char> chars_second = new List<char> {'b', 'g', 'f', 'r', 'o', 'c', 'h', 't', 'x' };
        List<char> chars_result;

        public List<char> Intersection()
        {
            chars_result = new List<char>();
            for (int i = 0; i < chars_first.Count; i++)
            {
                bool IsDuplicate = false;
                for (int j = 0; j < chars_second.Count; j++)
                {
                    if (chars_first[i] == chars_second[j])
                    {
                        for (int k = 0; k < chars_result.Count; k++)
                        {
                            if (chars_first[i] == chars_result[k])
                            {
                                IsDuplicate = true;
                                break;
                            }
                        }
                        if (!IsDuplicate)
                        {
                            chars_result.Add(chars_first[i]);
                        }
                        break;
                    }
                }
            }

            foreach (var item in chars_result)
            {
                Console.WriteLine(item);
            }

            return chars_result;
        }

        public List<char> IntersectionOptimal()
        {
            HashSet<char> set = new HashSet<char>();
            chars_result = new List<char>();

            // Store first list
            foreach (char ch in chars_first)
            {
                set.Add(ch);
            }

            // Find intersection
            foreach (char ch in chars_second)
            {
                if (set.Contains(ch))
                {
                    chars_result.Add(ch);
                    set.Remove(ch);   // Prevent duplicates
                }
            }

            foreach (char ch in chars_result)
            {
                Console.WriteLine(ch);
            }

            return chars_result;
        }
    }
}
