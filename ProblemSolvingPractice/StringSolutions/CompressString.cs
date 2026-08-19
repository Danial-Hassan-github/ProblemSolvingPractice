using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingPractice.StringSolutions
{
    public class CompressString
    {
        string str = "aaaabbbbhnnniooot";
        string result;

        public string Compress()
        {
            char first;
            char firstNext;
            char prev = '\0';
            int counter = 0;

            result = "";

            for (int i = 0; i < str.Length;)
            {
                first = str[i];

                if ((i + counter) > (str.Length - 1))
                {
                    result += prev.ToString() + counter;
                    break;
                }

                firstNext = str[i + counter];

                if (first == firstNext)
                {
                    prev = first;
                    counter++;
                }
                else
                {
                    result += prev.ToString()+counter;
                    i = i + counter;
                    counter = 0;
                }
            }

            Console.WriteLine(result);
            return result;
        }

        public string CompressCleaner()
        {
            string result = "";

            int i = 0;

            while (i < str.Length)
            {
                char current = str[i];
                int count = 0;

                while (i < str.Length && str[i] == current)
                {
                    count++;
                    i++;
                }

                result += current + count.ToString();
            }

            return result;
        }
    }
}
