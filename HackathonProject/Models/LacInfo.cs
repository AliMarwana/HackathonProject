namespace HackathonProject.Models
{
    public class LacInfo
    {
        public string DisplayName { get; set; }
        public LacStatus LacStatus { get; set; }
        public List<Arc> Arcs { get; set; }
        public LacMode LacMode { get; set; }
        
    }
}
