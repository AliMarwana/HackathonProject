using TwinCAT.Ads;

namespace HackathonProject.Services
{
    public class ForwardService
    {
        AdsClient _adsClient;

        public ForwardService(AdsClient adsClient)
        {
            _adsClient = adsClient;
        }

        public void Forward1()
        {
            _adsClient.Connect(AmsNetId.Local, 851);
            _adsClient.WriteValue("GIO.Ob0101_ARC_EnableController", true);
            _adsClient.WriteValue("GIO.Ib0101_ARC_Stop", true);
            _adsClient.WriteValue("GIO.Ib0101_ARC_ControllerReady", true);
            //_adsClient.WriteValue("GIO.Ob0101_ARC_EnableContoller", true);
        }
        public void Forward2()
        {
            _adsClient.WriteValue("GIO.Ib01_Motor_2_Forward", true);
            _adsClient.WriteValue("GIO.Ib0102_ARC_GapDetection_1_RC0204", true);
            _adsClient.WriteValue("GIO.Ib0102_ARC_ControllerReady", true);
            _adsClient.WriteValue("GIO.Ob0102_ARC_EnableContoller", true);
        }
        public void Forward3()
        {
            _adsClient.WriteValue("GIO.Ib01_Motor_3_Forward", true);
            _adsClient.WriteValue("GIO.Ib0103_ARC_Stop", true);
            _adsClient.WriteValue("GIO.Ib0103_ARC_ControllerReady", true);
            _adsClient.WriteValue("GIO.Ob0103_ARC_EnableContoller", true);
        }
        public void Forward4_1()
        {
            //4_1
            _adsClient.WriteValue("GIO.Ib01_Motor_4_Forward", true);
            _adsClient.WriteValue("GIO.Ib0104e01_RC_Stop", true);
            _adsClient.WriteValue("GIO.Ib0104e01_RC_ControllerReady", true);
            _adsClient.WriteValue("GIO.Ob0104e01_RC_EnableContoller", true);
        }
        public void Forward4_2()
        {
            //4_2
            _adsClient.WriteValue("GIO.Ib01_Motor_4_Forward", true);
            _adsClient.WriteValue("GIO.Ib0104e02_RC_Stop", true);
            _adsClient.WriteValue("GIO.Ib0104e02_RC_ControllerReady", true);
            _adsClient.WriteValue("GIO.Ob0104e02_RC_EnableContoller", true);
        }
        public void Forward5()
        {
            _adsClient.WriteValue("GIO.Ib01_Motor_5_Forward", true);
            _adsClient.WriteValue("GIO.Ib0105_ARC_Stop", true);
            _adsClient.WriteValue("GIO.Ib0105_ARC_ControllerReady", true);
            _adsClient.WriteValue("GIO.Ob0105_ARC_EnableContoller", true);
        }
        public void Forward6_1()
        {
            _adsClient.WriteValue("GIO.Ib01_Motor_6_Forward", true);
            _adsClient.WriteValue("GIO.Ib0106e01_ARC_Stop", true);
            _adsClient.WriteValue("GIO.Ib0106e01_ARC_ControllerReady", true);
            _adsClient.WriteValue("GIO.Ob0106e01_ARC_EnableContoller", true);
        }
        public void Forward6_2()
        {
            _adsClient.WriteValue("GIO.Ib01_Motor_6_Forward", true);
            _adsClient.WriteValue("GIO.Ib0106e02_RC_Stop", true);
            _adsClient.WriteValue("GIO.Ib0106e02_RC_ControllerReady", true);
            _adsClient.WriteValue("GIO.Ob0106e02_RC_EnableContoller", true);
        }
        public void Forward6_3()
        {
            _adsClient.WriteValue("GIO.Ib01_Motor_6_Forward", true);
            _adsClient.WriteValue("GIO.Ib0106e03_RC_Stop", true);
            _adsClient.WriteValue("GIO.Ib0106e03_RC_ControllerReady", true);
            _adsClient.WriteValue("GIO.Ob0106e03_RC_EnableContoller", true);
        }
        public void Forward7()
        {
            _adsClient.WriteValue("GIO.Ib01_Motor_8_Forward", true);
            _adsClient.WriteValue("GIO.Ib0107_ARC_Stop", true);
            _adsClient.WriteValue("GIO.Ib0107_ARC_ControllerReady", true);
            _adsClient.WriteValue("GIO.Ob0107_ARC_EnableContoller", true);
        }
        public void Forward8()
        {
            _adsClient.WriteValue("GIO.Ib01_Motor_8_Forward", true);
            _adsClient.WriteValue("GIO.Ib0108_ARC_Stop", true);
            _adsClient.WriteValue("GIO.Ib0108_ARC_ControllerReady", true);
            _adsClient.WriteValue("GIO.Ob0108_ARC_EnableContoller", true);
        }
        public void Forward9()
        {
            _adsClient.WriteValue("GIO.Ib01_Motor_8_Forward", true);
            _adsClient.WriteValue("GIO.Ib0109_ARC_Stop", true);
            _adsClient.WriteValue("GIO.Ib0109_ARC_ControllerReady", true);
            _adsClient.WriteValue("GIO.Ob0109_ARC_EnableContoller", true);
        }
        public void Forward10()
        {
            _adsClient.WriteValue("GIO.Ib01_Motor_10_Forward", true);
            _adsClient.WriteValue("GIO.Ib0110_ARC_Stop", true);
            _adsClient.WriteValue("GIO.Ib0110_ARC_ControllerReady", true);
            _adsClient.WriteValue("GIO.Ob0110_ARC_EnableContoller", true);
        }
        public void Forward11()
        {
            _adsClient.WriteValue("GIO.Ib01_Motor_11_Forward", true);
            _adsClient.WriteValue("GIO.Ib0111_ARC_Stop", true);
            _adsClient.WriteValue("GIO.Ib0111_ARC_ControllerReady", true);
            _adsClient.WriteValue("GIO.Ob0111_ARC_EnableContoller", true);
        }
        public void Forward12()
        {
            _adsClient.WriteValue("GIO.Ib01_Motor_12_Forward", true);
            _adsClient.WriteValue("GIO.Ib0112_LT_Bottom", true);
            _adsClient.WriteValue("GIO.Ib0112_SCL_ControllerReady", true);
            _adsClient.WriteValue("GIO.Ob0112_ARC_EnableContoller", true);
        }

        public void Forward13_1()
        {
            _adsClient.WriteValue("GIO.Ib01_Motor_13_Forward", true);
            _adsClient.WriteValue("GIO.Ib0113e01_ARC_Stop", true);
            _adsClient.WriteValue("GIO.Ib0113e01_ARC_ControllerReady", true);
            _adsClient.WriteValue("GIO.Ob0113e01_ARC_EnableContoller", true);
        }
        public void Forward13_2()
        {
            _adsClient.WriteValue("GIO.Ib01_Motor_13_Forward", true);
            _adsClient.WriteValue("GIO.Ib0113e02_ARC_Stop", true);
            _adsClient.WriteValue("GIO.Ib0113e02_ARC_ControllerReady", true);
            _adsClient.WriteValue("GIO.Ob0113e02_ARC_EnableContoller", true);
        }
        public void Forward14()
        {
            _adsClient.WriteValue("GIO.Ib01_Motor_14_Forward", true);
            _adsClient.WriteValue("GIO.Ib0114_ARC_Stop", true);
            _adsClient.WriteValue("GIO.Ib0114_ARC_ControllerReady", true);
            _adsClient.WriteValue("GIO.Ob0114_ARC_EnableContoller", true);
        }
        public void Forward15()
        {
            _adsClient.WriteValue("GIO.Ib01_Motor_15_Forward", true);
            _adsClient.WriteValue("GIO.Ib0115_ARC_Stop", true);
            _adsClient.WriteValue("GIO.Ib0115_ARC_ControllerReady", true);
            _adsClient.WriteValue("GIO.Ob0115_ARC_EnableContoller", true);
        }
        public void Forward16()
        {
            _adsClient.WriteValue("GIO.Ib01_Motor_16_Forward", true);
            _adsClient.WriteValue("GIO.Ib0116_LT_Bottom", true);
            _adsClient.WriteValue("GIO.Ib0116_SCL_ControllerReady", true);
            _adsClient.WriteValue("GIO.Ob0116_ARC_EnableContoller", true);
        }
        //FOR LAC2
        public void Forward2_2()
        {
            _adsClient.WriteValue("GIO.Ib02_Motor_15_Forward", true);
            _adsClient.WriteValue("GIO.Ib0202_RC_Stop", true);
            _adsClient.WriteValue("GIO.Ib0202_RC_ControllerReady", true);
            _adsClient.WriteValue("GIO.Ob0115_ARC_EnableContoller", true);
        }
        public void Forward3_1()
        {
            _adsClient.WriteValue("GIO.Ib02_Motor_3_1_Forward", true);
            _adsClient.WriteValue("GIO.Ib0203e01_RC_Stop", true);
            _adsClient.WriteValue("GIO.Ib0203e01_RC_ControllerReady", true);
            _adsClient.WriteValue("GIO.Ob0115_ARC_EnableContoller", true);
        }
        public void Forward3_2()
        {
            _adsClient.WriteValue("GIO.Ib02_Motor_3_2_Forward", true);
            _adsClient.WriteValue("GIO.Ib0203e02_RC_Stop", true);
            _adsClient.WriteValue("GIO.Ib0203e02_RC_ControllerReady", true);
            _adsClient.WriteValue("GIO.Ob0115_RC_EnableContoller", true);
        }
        public void Forward4()
        {
            _adsClient.WriteValue("GIO.Ib02_Motor_4_Forward", true);
            _adsClient.WriteValue("GIO.Ib0203e02_RC_Stop", true);
            _adsClient.WriteValue("GIO.Ib0203e02_RC_ControllerReady", true);
            _adsClient.WriteValue("GIO.Ob0115_RC_EnableContoller", true);
        }

    }
}
