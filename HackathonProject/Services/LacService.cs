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
            _ads.Connect(AmsNetId.Local, 851);
            var State = _ads.ReadValue<int>("LAC01.fbLacManager.stLacData.eOmState");
            return DefaultConfig.LacModes().Where(p => p.Value == State).FirstOrDefault();

        }
        public LacMode GetModeLac2()
        {
            _ads.Connect(AmsNetId.Local, 851);
            var State = _ads.ReadValue<int>("LAC02.fbLacManager.stLacData.eOmState");
            return DefaultConfig.LacModes().Where(p => p.Value == State).FirstOrDefault();
        }
            public void SetModeLac1(int State)
            {
            _ads.Connect(AmsNetId.Local, 851);
            List<LacMode> modes = new List<LacMode>();
            _ads.WriteValue("LAC01.fbLacManager.stLacData.eOmState", State);
            _ads.WriteValue("LAC01.fbLacManager.stLacData.eOmSelect", State);
            _ads.WriteValue("LAC01.fbLacManager.stLacData.bAccept", true);
        }
            public void SetModeLac2(int State)
        {
            _ads.Connect(AmsNetId.Local, 851);
            List<LacMode> modes = new List<LacMode>();
            _ads.WriteValue("LAC02.fbLacManager.stLacData.eOmState", State);
            _ads.WriteValue("LAC02.fbLacManager.stLacData.eOmSelect", State);
            _ads.WriteValue("LAC02.fbLacManager.stLacData.bAccept", true);
        }
        public List<LacInfo> GetLacInfos()
        {
            _ads.Connect(AmsNetId.Local, 851);
            List<LacInfo> lacInfos = DefaultConfig.LacInfos();
            LacInfo lac1 = lacInfos.Where(p => p.DisplayName == DefaultConfig.Lac01).FirstOrDefault()!;
            LacInfo lac2 = lacInfos.Where(p => p.DisplayName == DefaultConfig.Lac02).FirstOrDefault()!;
            lac1.LacMode = GetModeLac1();
            lac2.LacMode = GetModeLac2();
            return lacInfos;
        }
        public LacInfo GetSpecificLacInfo(string lacName)
        {
            _ads.Connect(AmsNetId.Local, 851);
            LacInfo lacInfo = new LacInfo();
            List<LacInfo> lacInfos = DefaultConfig.LacInfos();
            if (lacName == DefaultConfig.Lac01)
            {
                lacInfo = lacInfos.Where(p => p.DisplayName == DefaultConfig.Lac01).FirstOrDefault()!;
                lacInfo.LacMode = GetModeLac1();
            }
            if (lacName == DefaultConfig.Lac02)
            {
                lacInfo = lacInfos.Where(p => p.DisplayName == DefaultConfig.Lac02).FirstOrDefault()!;
                lacInfo.LacMode = GetModeLac2();
            }
            return lacInfo;
        }
    }
}
