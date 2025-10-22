namespace HW7_BehavioralPatterns
{
    public class TVOnCommand : ICommand
    {
        private TV _tv;
        public TVOnCommand(TV tv) { _tv = tv; }
        public void Execute() { _tv.TurnOn(); }
        public void Undo() { _tv.TurnOff(); }
    }
}