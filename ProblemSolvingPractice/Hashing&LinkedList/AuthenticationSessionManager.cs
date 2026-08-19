namespace ProblemSolvingPractice.Hashing_LinkedList
{
    public class Session
    {
        public string SessionId { get; set; }
        public DateTime ExpiresAt { get; set; }
    }

    public class AuthenticationSessionManager
    {
        Dictionary<string, Session> _sessions = new Dictionary<string, Session>();
        public void Login(string userId)
        {
            string sessionId = Guid.NewGuid().ToString();
            _sessions[userId] = new Session { 
                SessionId = sessionId, 
                ExpiresAt = DateTime.UtcNow.AddMinutes(30) 
            };
        }

        public void Logout(string userId)
        {
            _sessions.Remove(userId);
        }

        public bool IsLoggedIn(string userId)
        {
            if (!_sessions.TryGetValue(userId, out Session? session))
                return false;

            if (session.ExpiresAt <= DateTime.UtcNow)
            {
                _sessions.Remove(userId);
                return false;
            }

            return true;
        }
    }
}
