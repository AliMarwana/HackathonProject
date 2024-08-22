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
            ads.Connect(AmsNetId.Local,851);
            //ST_OperationMode.eOmState;
            //ST_OperationMode.eOmSelect
            //ST_OperationMode.bAccept
           
            //FB_LacManager.stLacData;

            if (ads.IsConnected)
            {
                var bAccept = ads.ReadValue("LAC01.fbLacManager.stLacData.bAccept");
                var State = ads.ReadValue("LAC01.fbLacManager.stLacData.eOmState");
                var Select = ads.ReadValue("LAC01.fbLacManager.stLacData.eOmSelect");

                Console.WriteLine("Changement des valeurs");
                
                ads.WriteValue("LAC01.fbLacManager.stLacData.bAccept", true);
                ads.WriteValue("LAC01.fbLacManager.stLacData.eOmState",30);
                ads.WriteValue("LAC01.fbLacManager.stLacData.eOmSelect",20);

                Console.WriteLine("ReLecture des valeurs");

                var bAccept1 = ads.ReadValue("LAC01.fbLacManager.stLacData.bAccept");
                var State1 = ads.ReadValue("LAC01.fbLacManager.stLacData.eOmState");
                var Select1 = ads.ReadValue("LAC01.fbLacManager.stLacData.eOmSelect");

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
