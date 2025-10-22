namespace HW7_BehavioralPatterns
{
    public interface ICommand
    {
        void Execute();
        void Undo();
    }
}