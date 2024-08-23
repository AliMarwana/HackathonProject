using HackathonProject.Models;

namespace HackathonProject.DefaultConfiguration
{
    public static class DefaultConfig
    {
        public static string Lac01 { get; set; } = "LAC001";
        public static string Lac02 { get; set; } = "LAC002";
        public static string Automatic { get; set; } = "Automatic";
        public static string Manual { get; set; } = "Manual";
        public static string Off { get; set; } = "Off";
        public static string Setup { get; set; } = "Setup";
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
        public static List<LacInfo> LacInfos()
        {
            List<LacInfo> lacInfos = new List<LacInfo>();
            lacInfos.Add(new LacInfo { DisplayName = Lac01 });
            lacInfos.Add(new LacInfo { DisplayName = Lac02 });
            return lacInfos;
        }
        public static Machine GetMachine()
        {
            Machine machine = new Machine();
            return machine;
        }
    }
}
