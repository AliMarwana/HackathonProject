using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TwinCAT.Ads;

namespace HackathonProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private AdsClient ads;
        public TestController()
        {
            ads = new AdsClient();
        }
        //[HttpGet]
        //public bool GetStateLac1()
        //{
        //    return true;
        //}
        //[HttpGet]
        //public bool GetStateLac2()
        //{
        //    return true;
        //}
        [HttpGet]
        public bool PutModeAuto()
        {
            //ST_OperationMode.eOmState;
            //ST_OperationMode.eOmSelect
            //ST_OperationMode.bAccept

            //FB_LacManager.stLacData;
            return false;
        }
        //[HttpGet]
        //public bool PutModeManuel()
        //{
        //    return false;
        //}
        //[HttpGet]
        //public bool Confirmation()
        //{
        //    return false;
        //}
        //[HttpGet]
        //public bool Arret()
        //{
        //    return false;
        //}

    }
}
