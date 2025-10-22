namespace HW_Patterns_Advanced
{
    public class TVOnCommand : ICommand
    {
        private Television _tv;
        public TVOnCommand(Television tv) { _tv = tv; }
        public void Execute() => _tv.On();
        public void Undo() => _tv.Off();
    }
}