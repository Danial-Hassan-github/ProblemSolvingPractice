namespace ProblemSolvingPractice.StringSolutions
{
    public class ReverseWordsInString
    {
        public void ReverseWords(string str)
        {
            string[] words = str.Split(' ');
            str = "";
            for (int i = words.Length - 1; i >= 0; i--)
            {
                str += words[i];
                if (i != 0)
                    str += " ";
            }

            Console.WriteLine(str);
        }
    }
}
