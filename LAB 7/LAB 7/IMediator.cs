namespace HW_Patterns_Behavioral
{
    public interface IMediator
    {
        void SendMessage(string message, Colleague colleague);
    }
}
