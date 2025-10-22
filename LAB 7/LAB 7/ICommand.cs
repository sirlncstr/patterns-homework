namespace HW_Patterns_Behavioral
{
    public interface ICommand
    {
        void Execute();
        void Undo();
    }
}