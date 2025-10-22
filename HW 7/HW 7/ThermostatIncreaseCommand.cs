namespace HW7_BehavioralPatterns
{
    public class ThermostatIncreaseCommand : ICommand
    {
        private Thermostat _thermostat;
        public ThermostatIncreaseCommand(Thermostat thermostat) { _thermostat = thermostat; }
        public void Execute() { _thermostat.IncreaseTemp(); }
        public void Undo() { _thermostat.DecreaseTemp(); }
    }
}