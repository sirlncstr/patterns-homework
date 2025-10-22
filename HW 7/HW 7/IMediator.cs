namespace HW7_BehavioralPatterns
{
    public interface IMediator
    {
        void SendMessage(string message, User sender);
        void SendPrivateMessage(string message, User sender, string recipientName);
        void RegisterUser(User user);
        void UnregisterUser(User user);
    }
}