using HackathonProject.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TwinCAT.Ads;

namespace HackathonProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private AdsClient ads = new AdsClient();
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
            ads.Connect(851);
            if (ads.IsConnected)
            {
                return Json(new { isConnected = true });
            }
            else
            {
                return Json(new { isConnected = false });
            }
            //  return View();
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
