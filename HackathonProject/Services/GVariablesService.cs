using HackathonProject.Models;
using System.Net.Sockets;
using TwinCAT.Ads;

namespace HackathonProject.NewFolder
{
    public class GVariablesService
    {
        AdsClient _adsClient;
        public GVariablesService(AdsClient client)
        {
            _adsClient = client;    
        }
        public bool ControlVoltageOn { get; set; }
        public bool ControlVoltageOff { get; set; }
        public bool IsLac1On { get; set; }
        public bool IsLac2On { get; set; }
        public bool IsManual { get; set; }
        public bool IsAutomatic { get; set; }
        
        public T ReadVar<T>(string nameVar)
        {
            _adsClient.Connect(AmsNetId.Local, 851);
            var GVariable = _adsClient.CreateVariableHandle(nameVar);
         var realVariable = (T)_adsClient.ReadAny(GVariable, typeof(T));
         return realVariable;
        }
        public void WriteVar<T>(string nameVar, T variableToInsert)
        {
            _adsClient.Connect(AmsNetId.Local, 851);
            var GVariable = _adsClient.CreateVariableHandle(nameVar);
            _adsClient.WriteAny(GVariable, variableToInsert);
        } 
        public GlobalVars GetGlobal()
        {
            _adsClient.Connect(AmsNetId.Local, 851);
            bool controlVoltageOff = ReadVar<bool>("GIO.IbIP02_ControlVoltageOff_NC");
            bool controlVoltageOn = ReadVar<bool>("GIO.IbIP02_ControlVoltageOn");
            GlobalVars globalVars = new GlobalVars();
            globalVars.ControlVoltageOff = controlVoltageOff;
            globalVars.ControlVoltageOn = controlVoltageOn;

            return globalVars;
        }
        public bool IsVoltageOn()
        {
            bool controlVoltageOn = ReadVar<bool>("GIO.IbIP02_ControlVoltageOn");
            return controlVoltageOn;
        }
     
    }
}
