namespace HW_Patterns_Advanced
{
    public interface ICommand
    {
        void Execute();
        void Undo();
    }
}

