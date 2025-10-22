namespace HW7_BehavioralPatterns
{
    public class DoorOpenCommand : ICommand
    {
        private Door _door;
        public DoorOpenCommand(Door door) { _door = door; }
        public void Execute() { _door.Open(); }
        public void Undo() { _door.Close(); }
    }
}