using HackathonProject.DefaultConfiguration;
using HackathonProject.Models;
using TwinCAT.Ads;

namespace HackathonProject.Services
{
    public class LacService
    {
        AdsClient _ads;

        public LacService(AdsClient adsClient)
        {
            _ads = adsClient;
        }
        public LacMode GetModeLac1()
        {
            var bAccept = _ads.ReadValue("LAC01.fbLacManager.stLacData.bAccept");
            var State = _ads.ReadValue<int>("LAC01.fbLacManager.stLacData.eOmState");
            return DefaultConfig.LacModes().Where(p => p.Value == State).FirstOrDefault();

        }
        public LacMode GetModeLac2()
        {
            var bAccept = _ads.ReadValue("LAC02.fbLacManager.stLacData.bAccept");
            var State = _ads.ReadValue<int>("LAC02.fbLacManager.stLacData.eOmState");
            return DefaultConfig.LacModes().Where(p => p.Value == State).FirstOrDefault();
        }
            public void SetModeLac1(int State)
            {
                List<LacMode> modes = new List<LacMode>();
            _ads.WriteValue("LAC01.fbLacManager.stLacData.bAccept", true);
            _ads.WriteValue("LAC01.fbLacManager.stLacData.eOmState", State);
            _ads.WriteValue("LAC01.fbLacManager.stLacData.eOmSelect", State);
            }
            public void SetModeLac2(int State)
        {
            List<LacMode> modes = new List<LacMode>();
            _ads.WriteValue("LAC02.fbLacManager.stLacData.bAccept", true);
            _ads.WriteValue("LAC02.fbLacManager.stLacData.eOmState", State);
            _ads.WriteValue("LAC02.fbLacManager.stLacData.eOmSelect", State);
        }
        }
}
