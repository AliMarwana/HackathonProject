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
            try
            {
                _ads.Connect(AmsNetId.Local, 851);
               /* if (_ads.IsConnected)
                {
                   
                }*/

                return View();
            }
            catch (Exception ex)
            {
                return Ok("You are not connected");
            };
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