using HackathonProject.Models;

namespace HackathonProject.DefaultConfiguration
{
    public static class DefaultConfig
    {
        public static string Lac01 { get; set; } = "Lac01";
        public static string Lac02 { get; set; } = "Lac02";
        public static List<LacMode> LacModes()
        {
            List<LacMode> lacModes = new List<LacMode>();
            lacModes.Add(new LacMode { Description = "Automatic", Value = 30 });
            lacModes.Add(new LacMode { Description = "Manual", Value = 20 });
            lacModes.Add(new LacMode { Description = "Off", Value = 0 });
            lacModes.Add(new LacMode { Description = "Setup", Value = 10 });
            return lacModes;
        }
        public static List<LacStatus> LacStatuses()
        {
            List<LacStatus> lacStatuses = new List<LacStatus>();
            lacStatuses.Add(new LacStatus { Description = "Standby" });
            return lacStatuses;
        }

    }
}
