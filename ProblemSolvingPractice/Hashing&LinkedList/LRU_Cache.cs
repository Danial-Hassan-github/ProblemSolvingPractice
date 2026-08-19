// Least Recently Used Cache
namespace ProblemSolvingPractice.Hashing_LinkedList
{
    public class LRU_Cache
    {
        int capacity;
        Dictionary<int, string> data = new();
        LinkedList<int> LRU = new();

        public LRU_Cache(int capacity)
        {
            this.capacity = capacity;
        }

        public string? Get(int key)
        {
            if (data.TryGetValue(key, out string? value))
            {
                LRU.Remove(key);
                LRU.AddLast(key);

                return value;
            }

            return null;
        }

        public void Put(int key, string value)
        {
            if (data.ContainsKey(key))
            {
                data[key] = value;

                LRU.Remove(key);
                LRU.AddLast(key);

                return;
            }

            if (data.Count >= capacity)
            {
                int leastUsedKey = LRU.First!.Value;

                LRU.RemoveFirst();
                data.Remove(leastUsedKey);
            }

            data.Add(key, value);
            LRU.AddLast(key);
        }
    }
}