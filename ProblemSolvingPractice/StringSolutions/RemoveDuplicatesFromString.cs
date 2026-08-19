using System.Text;

namespace ProblemSolvingPractice.StringSolutions
{
    public class RemoveDuplicatesFromString
    {
        public void RemoveDup(string str)
        {
            HashSet<char> dup = new HashSet<char>();
            StringBuilder result = new();
            for (int i = 0; i < str.Length; i++)
            {
                if (dup.Add(str[i]))
                    result.Append(str[i]); 
            }
            
            Console.WriteLine(result);
        }
    }
}
