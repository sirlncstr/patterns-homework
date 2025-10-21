using HW7_BehavioralPatterns;

namespace HW7_BehavioralPatterns
{
    public class DoorCloseCommand : ICommand
    {
        private Door _door;
        public DoorCloseCommand(Door door) { _door = door; }
        public void Execute() { _door.Close(); }
        public void Undo() { _door.Open(); }
    }
}