namespace HW7_BehavioralPatterns
{
    public class LightOnCommand : ICommand
    {
        private Light _light;
        public LightOnCommand(Light light) { _light = light; }
        public void Execute() { _light.TurnOn(); }
        public void Undo() { _light.TurnOff(); }
    }
}