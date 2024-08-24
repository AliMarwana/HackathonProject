using HackathonProject.DefaultConfiguration;
using HackathonProject.Models;
using HackathonProject.Services;
using HackathonProject.ViewModel;
using Microsoft.AspNetCore.Mvc;
using TwinCAT.Ads;

namespace HackathonProject.Controllers
{
    public class ConvoyeurPageController : Controller
    {
        private GVariablesService _variablesService;
        private LacService _lacService;
        private AdsClient _adsClient;
        
        public ConvoyeurPageController(GVariablesService variablesService, LacService lacService,
            AdsClient adsClient)
        {
                _variablesService = variablesService;
            _lacService = lacService;
            _adsClient = adsClient;
        }
        public IActionResult Index()
        {
            try
            {
                _adsClient.Connect(AmsNetId.Local, 851);
                List<LacInfo> lacInfos = new List<LacInfo>();
                lacInfos = _lacService.GetLacInfos();
                LacViewModel viewModel = new LacViewModel();
                viewModel.LacInfos = lacInfos;
                viewModel.MachineControlVoltageOn = _variablesService.IsVoltageOn();
                return View(viewModel);
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", "Error", new { message = ex.Message });
            };
        }
        public async Task<IActionResult> SetMode(string lacName, string mode)
        {
            try
            {
                LacInfo lacInfo = _lacService.GetSpecificLacInfo(lacName);
                if (lacName == DefaultConfig.Lac01)
                {
                    await _lacService.SetModeLac1(mode);
                }
                else
                {
                    await _lacService.SetModeLac2(mode);
                }
                return RedirectToAction("Index", "ConvoyeurPage");
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", "Error", new { message = ex.Message });
            };

        }
    }
}
