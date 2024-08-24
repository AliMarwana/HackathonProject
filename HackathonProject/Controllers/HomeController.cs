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
            this._ads = ads; 
        }
        public IActionResult Index()
        {
            try
            {
                //_ads.Connect(AmsNetId.Local, 851);
               /* if (_ads.IsConnected)
                {
                   
                }*/

                //var bForword = _ads.ReadValue("st01EL.fbMan.Button.bForward");
                //var bForword1 = _ads.ReadValue("st01EL.fbMan.Button.bForward");

                return View();
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", "Error", new {message = ex.Message});
            };
        }
        public IActionResult Privacy()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(string password, string mode)
        {
            if (mode == "expert" && password == "Expert-87.1990")
            {
                return RedirectToAction("Index", "Dashboard");
            }
            return RedirectToAction("Index", "Error", new { message = "Invalid password" });
        }
        /*[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }*/
    }
}