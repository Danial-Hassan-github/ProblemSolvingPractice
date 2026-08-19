namespace ProblemSolvingPractice.Hashing_LinkedList
{
    public class URL_Shortener
    {
        Dictionary<string, string> shortToLong = new Dictionary<string, string>();
        Dictionary<string, string> longToShort = new Dictionary<string, string>();

        public string Shorten(string longUrl)
        {
            foreach (var item in shortToLong)
            {
                if (item.Value == longUrl)
                {
                    return item.Key;
                }
            }

            string shortUrl = GenerateUniqueShortUrl();

            shortToLong.Add(shortUrl, longUrl);

            return shortUrl;
        }

        public string ShortenOptimal(string longUrl)
        {
            string? shortUrl;

            if (longToShort.TryGetValue(longUrl, out shortUrl))
            {
                return shortUrl;
            }

            shortUrl = GenerateUniqueShortUrl();

            shortToLong.Add(shortUrl, longUrl);
            longToShort.Add(longUrl, shortUrl);

            return shortUrl;
        }

        public string? Expand(string shortUrl)
        {
            if (shortToLong.TryGetValue(shortUrl, out string? longUrl))
            {
                return longUrl;
            }

            return null;
        }

        private string GenerateUniqueShortUrl()
        {
            string shortUrl;

            do
            {
                string code = Guid.NewGuid().ToString("N").Substring(0, 4);
                shortUrl = "www.sip.sh/" + code;

            } while (shortToLong.ContainsKey(shortUrl));

            return shortUrl;
        }
    }
}
