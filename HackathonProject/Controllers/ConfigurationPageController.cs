using HackathonProject.DefaultConfiguration;
using HackathonProject.Models;
using HackathonProject.NewFolder;
using HackathonProject.Services;
using HackathonProject.ViewModel;
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
            GlobalVars globalVars = _variablesService.GetGlobal();
            ConfigurationViewModel viewModel = new ConfigurationViewModel();
            viewModel.GlobalVars = globalVars;
            viewModel.LacInfo = lacInfo;
            return View(viewModel);
        }
        [HttpGet]
        public async Task<IActionResult> SetAction(string mode, string lacName)
        {
            LacInfo lacInfo = _lacService.GetSpecificLacInfo(lacName);
            if(lacName == DefaultConfig.Lac01)
            {
                await _lacService.SetModeLac1(mode);
            }
            else
            {
                await _lacService.SetModeLac2(mode);
            }
            return Ok();

        //    return RedirectToAction("Index", "Configuration", new {lacName = lacName});
        }
       
    }
}
