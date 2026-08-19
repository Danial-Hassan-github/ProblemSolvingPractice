namespace ProblemSolvingPractice.Hashing_LinkedList
{
    public class GroupAnagrams
    {
        List<string> words = new()
        {
            "world",
            "study",
            "cinema",
            "hello",
            "thing",
            "dusty",
            "random",
            "vase",
            "iceman",
            "angel",
            "save",
            "night",
            "glean",
            "below",
            "taste",
            "elbow",
            "state",
            "listen",
            "evil",
            "silent",
            "veil",
            "bat",
            "vile",
            "eat",
            "tea",
            "tan",
            "ate",
            "nat"
        };

        public Dictionary<string,List<string>> Group()
        {
            Dictionary<string, List<string>> groups = new Dictionary<string, List<string>> { };
            
            char[] current;
            for (int i = 0; i < words.Count; i++)
            {
                current = words[i].ToCharArray();
                Array.Sort(current);

                string key = new string(current);
                if (groups.ContainsKey(key))
                {
                    groups[key].Add(words[i]);
                }
                else
                {
                    groups.Add(key, new List<string> { words[i] });
                }
            }

            foreach (var item in groups)
            {
                foreach (var word in item.Value)
                {
                    Console.Write(word + " ");
                }
                Console.WriteLine();
            }

            return groups;
        }
    }
}
