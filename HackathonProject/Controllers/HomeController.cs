using HackathonProject.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TwinCAT.Ads;

namespace HackathonProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private AdsClient _ads;
        public HomeController(ILogger<HomeController> logger, AdsClient ads)
        {
            _logger = logger;
            _ads = ads; 
        }
        public IActionResult Index()
        {
            _ads.Connect(AmsNetId.Local,851);
            //ST_OperationMode.eOmState;
            //ST_OperationMode.eOmSelect
            //ST_OperationMode.bAccept
           
            //FB_LacManager.stLacData;

            if (_ads.IsConnected)
            {
                var bAccept = _ads.ReadValue("LAC01.fbLacManager.stLacData.bAccept");
                var State = _ads.ReadValue("LAC01.fbLacManager.stLacData.eOmState");
                var Select = _ads.ReadValue("LAC01.fbLacManager.stLacData.eOmSelect");

                Console.WriteLine("Changement des valeurs");
                
                _ads.WriteValue("LAC01.fbLacManager.stLacData.bAccept", true);
                _ads.WriteValue("LAC01.fbLacManager.stLacData.eOmState",30);
                _ads.WriteValue("LAC01.fbLacManager.stLacData.eOmSelect",20);

                Console.WriteLine("ReLecture des valeurs");

                var bAccept1 = _ads.ReadValue("LAC01.fbLacManager.stLacData.bAccept");
                var State1 = _ads.ReadValue("LAC01.fbLacManager.stLacData.eOmState");
                var Select1 = _ads.ReadValue("LAC01.fbLacManager.stLacData.eOmSelect");

                return Json(new { isConnected = true });
            }
            //else
            //{
            //    return Json(new { isConnected = false });
            //}
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
