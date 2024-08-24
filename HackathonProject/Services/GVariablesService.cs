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
            bool controlVoltageOff = ReadVar<bool>("GIO.IbIP02_ControlVoltageOff_NC");
            bool controlVoltageOn = ReadVar<bool>("GIO.IbIP02_ControlVoltageOn");
            GlobalVars globalVars = new GlobalVars();
            globalVars.ControlVoltageOff = ReadVar<bool>("GIO.IbIP02_ControlVoltageOff_NC");
            globalVars.ControlVoltageOn = ReadVar<bool>("GIO.IbIP02_ControlVoltageOn");

            globalVars.Controller_1 = ReadVar<bool>("GIO.Ib0101_ARC_ControllerReady");
            globalVars.moteur_1 = ReadVar<bool>("GIO.Ob0101_ARC_EnableController");
            globalVars.capter_1 = ReadVar<bool>("GIO.Ib0101_ARC_Stop");


            globalVars.Controller_2 = ReadVar<bool>("GIO.Ib0102_ARC_ControllerReady");
            globalVars.moteur_2 = ReadVar<bool>("GIO.Ob0102_ARC_EnableController");
            globalVars.capter_2 = ReadVar<bool>("GIO.Ib0102_ARC_GapDetection_1_RC0204");

            globalVars.Controller_3 = ReadVar<bool>("GIO.Ib0103_ARC_ControllerReady");
            globalVars.moteur_3 = ReadVar<bool>("GIO.Ob0103_ARC_EnableController");
            globalVars.capter_3 = ReadVar<bool>("GIO.Ib0103_ARC_Stop");

            globalVars.Controller_4_1 = ReadVar<bool>("GIO.Ib0104e01_RC_ControllerReady");
            globalVars.moteur_4_1 = ReadVar<bool>("GIO.Ob0104e01_RC_EnableController");
            globalVars.capter_4_1 = ReadVar<bool>("GIO.Ib0104e01_RC_Stop");

            globalVars.Controller_4_2 = ReadVar<bool>("GIO.Ib0104e02_RC_ControllerReady");
            globalVars.moteur_4_2 = ReadVar<bool>("GIO.Ob0104e02_RC_EnableController");
            globalVars.capter_4_2 = ReadVar<bool>("GIO.Ib0104e02_RC_Stop");

            globalVars.Controller_5 = ReadVar<bool>("GIO.Ib0105_ARC_ControllerReady");
            globalVars.moteur_5 = ReadVar<bool>("GIO.Ob0105_ARC_EnableController");
            globalVars.capter_5 = ReadVar<bool>("GIO.Ib0105_ARC_Stop");
            globalVars.capter_5_Enter_Close = ReadVar<bool>("GIO.Ib0105_ARC_Closed");

            globalVars.Controller_6_1 = ReadVar<bool>("GIO.Ib0106e01_ARC_ControllerReady");
            globalVars.moteur_6_1 = ReadVar<bool>("GIO.Ob0106e01_ARC_EnableController");
            globalVars.capter_6_1 = ReadVar<bool>("GIO.Ib0106e01_ARC_Stop");

            globalVars.Controller_6_2 = ReadVar<bool>("GIO.Ib0106e02_RC_ControllerReady");
            globalVars.moteur_6_2 = ReadVar<bool>("GIO.Ob0106e02_RC_EnableController");
            globalVars.capter_6_2 = ReadVar<bool>("GIO.Ib0106e02_RC_Stop");

            globalVars.Controller_6_3 = ReadVar<bool>("GIO.Ib0106e03_RC_ControllerReady");
            globalVars.moteur_6_3 = ReadVar<bool>("GIO.Ob0106e03_RC_EnableController");
            globalVars.capter_6_3 = ReadVar<bool>("GIO.Ib0106e03_RC_Stop");

            globalVars.Controller_7 = ReadVar<bool>("GIO.Ib0107_ARC_ControllerReady");
            globalVars.moteur_7 = ReadVar<bool>("GIO.Ob0107_ARC_EnableController");
            globalVars.capter_7 = ReadVar<bool>("GIO.Ib0107_ARC_Stop");

            globalVars.Controller_8 = ReadVar<bool>("GIO.Ib0108_ARC_ControllerReady");
            globalVars.moteur_8 = ReadVar<bool>("GIO.Ob0108_ARC_EnableController");
            globalVars.capter_8 = ReadVar<bool>("GIO.Ib0108_ARC_Stop");

            globalVars.Controller_9 = ReadVar<bool>("GIO.Ib0109_ARC_ControllerReady");
            globalVars.moteur_9 = ReadVar<bool>("GIO.Ob0109_ARC_EnableController");
            globalVars.capter_9 = ReadVar<bool>("GIO.Ib0109_ARC_Stop");

            globalVars.Controller_10 = ReadVar<bool>("GIO.Ib0110_ARC_ControllerReady");
            globalVars.moteur_10 = ReadVar<bool>("GIO.Ob0110_ARC_EnableController");
            globalVars.capter_10 = ReadVar<bool>("GIO.Ib0110_ARC_Stop");

            globalVars.Controller_11 = ReadVar<bool>("GIO.Ib0111_ARC_ControllerReady");
            globalVars.moteur_11 = ReadVar<bool>("GIO.Ob0111_ARC_EnableController");
            globalVars.capter_11 = ReadVar<bool>("GIO.Ib0111_ARC_Stop");

            globalVars.Controller_12 = ReadVar<bool>("GIO.Ib0112_SLC_ControllerReady");
            //To SEE link Moteur 
            globalVars.moteur_12 = ReadVar<bool>("GIO.Ob0109_ARC_EnableController");
            globalVars.capter_12_Bottom = ReadVar<bool>("GIO.Ib0112_LT_Bottom");
            globalVars.capter_12_Top = ReadVar<bool>("GIO.Ib0112_LT_Top");
            globalVars.capter_12_NoOverTemperature = ReadVar<bool>("GIO.Ib0112_SLC_NoOverTemperatureMotor");


            globalVars.Controller_13_1 = ReadVar<bool>("GIO.Ib0113e01_ARC_ControllerReady");
            globalVars.moteur_13_1 = ReadVar<bool>("GIO.Ob0113e01_ARC_EnableController");
            globalVars.capter_13_1 = ReadVar<bool>("GIO.Ib0113e01_ARC_Stop");

            globalVars.Controller_13_2 = ReadVar<bool>("GIO.Ib0113e02_ARC_ControllerReady");
            globalVars.moteur_13_2 = ReadVar<bool>("GIO.Ob0113e02_ARC_EnableController");
            globalVars.capter_13_2 = ReadVar<bool>("GIO.Ib0113e02_ARC_Stop");

            globalVars.Controller_14 = ReadVar<bool>("GIO.Ib0114_ARC_ControllerReady");
            globalVars.moteur_14 = ReadVar<bool>("GIO.Ob0114_ARC_EnableController");
            globalVars.capter_14 = ReadVar<bool>("GIO.Ib0114_ARC_Stop");

            //After

            globalVars.Controller_15 = ReadVar<bool>("GIO.Ib0115_ARC_ControllerReady");
            globalVars.moteur_15 = ReadVar<bool>("GIO.Ob0115_ARC_EnableController");
            globalVars.capter_15 = ReadVar<bool>("GIO.Ib0115_ARC_Stop");

            globalVars.Controller_16 = ReadVar<bool>("GIO.Ib0116_SLC_ControllerReady");
            globalVars.moteur_16 = ReadVar<bool>("GIO.Ob0116_SLC_EnableController");
            globalVars.capter_16_Bottom = ReadVar<bool>("GIO.Ib0116_LT_Bottom");
            globalVars.capter_16_Top = ReadVar<bool>("GIO.Ib0116_LT_Top");
            globalVars.capter_16_NoOverTemperature = ReadVar<bool>("GIO.Ib0116_SLC_NoOverTemperatureMotor");

            //Lac02 Controllers
            //Lac Start Or Off
            globalVars.StartOrOffLac2 = ReadVar<bool>("GIO.Ib02_LAC_EnergyIsolationSwitchOn");


            globalVars.Controller_2_2 = ReadVar<bool>("GIO.Ib0202_RC_ControllerReady");
            globalVars.moteur_2_2 = ReadVar<bool>("GIO.Ob0202_RC_EnableController");
            globalVars.capter_2_2 = ReadVar<bool>("GIO.Ib0202_RC_Stop");
            globalVars.capter_2_2_BackSide = ReadVar<bool>("GIO.Ib0202_RC_BackSide");

            globalVars.Controller_3_1 = ReadVar<bool>("GIO.Ib0203e01_RC_ControllerReady");
            globalVars.moteur_3_1 = ReadVar<bool>("GIO.Ob0203e01_RC_EnableController");
            globalVars.capter_3_1 = ReadVar<bool>("GIO.Ib0203e01_RC_Stop");


            globalVars.Controller_3_2 = ReadVar<bool>("GIO.Ib0203e02_RC_ControllerReady");
            globalVars.moteur_3_2 = ReadVar<bool>("GIO.Ob0203e02_RC_EnableController");
            globalVars.capter_3_2 = ReadVar<bool>("GIO.Ib0203e02_RC_Stop");

            globalVars.Controller_4 = ReadVar<bool>("GIO.Ib0204_RC_ControllerReady");
            globalVars.moteur_4 = ReadVar<bool>("GIO.Ob0204_RC_EnableController");
            globalVars.capter_4 = ReadVar<bool>("GIO.Ib0204_RC_Stop");

            globalVars.Lac1VoltageOn = ReadVar<bool>("LAC01.fbLacManager.RefLacData.bControlVoltageOn");
            globalVars.Lac2VoltageOn = ReadVar<bool>("LAC02.fbLacManager.RefLacData.bControlVoltageOn");


            return globalVars;
        }
        public bool IsVoltageOn()
        {
            bool controlVoltageOn = ReadVar<bool>("GIO.IbIP02_ControlVoltageOn");
            return controlVoltageOn;
        }
     
    }
}
