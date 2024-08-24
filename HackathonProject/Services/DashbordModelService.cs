using HackathonProject.Models;
using TwinCAT.Ads;

namespace HackathonProject.Services
{
    public class DashbordModelService
    {
        AdsClient _adsClient;
        public DashbordModelService(AdsClient client)
        {
            _adsClient = client;
        }

        public T ReadVar<T>(string nameVar)
        {
            _adsClient.Connect(AmsNetId.Local, 851);
            var GVariable = _adsClient.CreateVariableHandle(nameVar);
            var realVariable = (T)_adsClient.ReadAny(GVariable, typeof(T));
            return realVariable;
        }

        public DashbordModel GetDashbordProperties()
        {
            DashbordModel dash = new DashbordModel();
            //dash.ControlOnValtage = ReadVar<bool>("GIO.IbIP02_ControlVoltageOn");
            dash.ControlOnValtage = ReadVar<bool>("LAC01.fbLacManager.RefLacData.bControlVoltageOn");

            dash.LampTest = ReadVar<bool>("GIO.IbLP01_LamptestHornTestInfeed");
            dash.SystemStartOff = ReadVar<bool>("GIO.IbLP01_SystemStart");
            
            dash.Lac1VoltageOn = ReadVar<bool>("LAC01.fbLacManager.RefLacData.bControlVoltageOn");
            dash.Lac2VoltageOn = ReadVar<bool>("LAC02.fbLacManager.RefLacData.bControlVoltageOn");
            dash.Lac2Mode = ReadVar<int>("LAC02.fbLacManager.stLacData.eOmState");
            dash.Lac1Mode = ReadVar<int>("LAC01.fbLacManager.stLacData.eOmState");
            dash.Lac2EnergyOn = ReadVar<bool>("GIO.Ib02_LAC_EnergyIsolationSwitchOn");
            dash.Lac1EnergyOn = ReadVar<bool>("GIO.Ib01_LAC_EnergyIsolationSwitchOn");



            return dash;
        }
    }
}
