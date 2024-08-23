using HackathonProject.Models;
using HackathonProject.NewFolder;
using HackathonProject.Services;
using Microsoft.AspNetCore.Mvc;
using TwinCAT.Ads;

namespace HackathonProject.Controllers
{
    public class ConfigurationPageController : Controller
    {
        private readonly GVariablesService _variablesService;
        private readonly LacService _lacService;
        private readonly AdsClient _adsClient;
        
        public ConfigurationPageController(GVariablesService variablesService, LacService lacService,
            AdsClient adsClient)
        {
            _variablesService = variablesService;
            _lacService = lacService;
            _adsClient = adsClient;
        }
        public IActionResult Index(string lacName)
        {
            _adsClient.Connect(AmsNetId.Local, 851);
            LacInfo lacInfo = _lacService.GetSpecificLacInfo(lacName);
            return View();
        }
       
    }
}
