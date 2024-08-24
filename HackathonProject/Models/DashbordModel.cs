namespace HackathonProject.Models
{
    public class DashbordModel
    {
        public bool SystemStartOff { get; set; }
        public bool LampTest { get; set; }
        public bool ControlOnValtage { get; set; }
        public bool  EmergencyStop { get; set; }
        public bool CollectingFailure { get; set; }

        public bool Lac1VoltageOn { get; set; }
        public bool Lac2VoltageOn { get; set; }
        public int Lac1Mode { get;set; }
        public int Lac2Mode { get;set; }
        public bool Lac2EnergyOn { get; set; }
        public bool Lac1EnergyOn { get; set; }

    }
}
