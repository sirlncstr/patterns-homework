namespace HW_Patterns_Advanced
{
    public interface IUser
    {
        string Name { get; }
        void ReceiveMessage(string message, string senderName);
    }
}