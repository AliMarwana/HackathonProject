using HackathonProject.DefaultConfiguration;
using HackathonProject.Models;
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
        private readonly ForwardService _forwarService;
        
        public ConfigurationPageController(GVariablesService variablesService, LacService lacService,
            AdsClient adsClient, ForwardService forwarService)
        {
            _variablesService = variablesService;
            _lacService = lacService;
            _adsClient = adsClient;
            _forwarService = forwarService;
        }
        public IActionResult Index(string lacName)
        {
            try
            {
                _adsClient.Connect(AmsNetId.Local, 851);
                LacInfo lacInfo = _lacService.GetSpecificLacInfo(lacName);
                GlobalVars globalVars = _variablesService.GetGlobal();
                ConfigurationViewModel viewModel = new ConfigurationViewModel();
                viewModel.GlobalVars = globalVars;
                viewModel.LacInfo = lacInfo;
                return View(viewModel);
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", "Error", new { message = ex.Message });
            };
        }
        [HttpGet]
        public async Task<IActionResult> SetAction(string mode, string lacName)
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
                return Ok();
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", "Error", new { message = ex.Message });
            };
            //    return RedirectToAction("Index", "Configuration", new {lacName = lacName});
        }

        public async Task<IActionResult> Forward(int n)
        {
            try
            {
                switch (n)
                {
                    case 1:
                        _forwarService.Forward1();
                        return Ok();
                    case 2:
                        _forwarService.Forward2();
                        return Ok();
                    case 3:
                        _forwarService.Forward3();
                        return Ok();
                    case 4:
                        _forwarService.Forward4_1();
                        return Ok();
                    case 5:
                        _forwarService.Forward4_2();
                        return Ok();
                    case 6:
                        _forwarService.Forward5();
                        return Ok();
                    case 7:
                        _forwarService.Forward6_1();
                        return Ok();
                    case 8:
                        _forwarService.Forward6_2();
                        return Ok();
                    case 9:
                        _forwarService.Forward6_3();
                        return Ok();
                    case 10:
                        _forwarService.Forward7();
                        return Ok();
                    case 11:
                        _forwarService.Forward8();
                        return Ok();
                    case 12:
                        _forwarService.Forward9();
                        return Ok();
                    case 13:
                        _forwarService.Forward10();
                        return Ok();
                    case 14:
                        _forwarService.Forward11();
                        return Ok();
                    case 15:
                        _forwarService.Forward12();
                        return Ok();
                    case 16:
                        _forwarService.Forward13_1();
                        return Ok();
                    case 17:
                        _forwarService.Forward13_2();
                        return Ok();
                    case 18:
                        _forwarService.Forward14();
                        return Ok();
                    case 19:
                        _forwarService.Forward15();
                        return Ok();
                    case 20:
                        _forwarService.Forward16();
                        return Ok();
                    case 21:
                        _forwarService.Forward4();
                        return Ok();
                    case 22:
                        _forwarService.Forward2_2();
                        return Ok();
                    case 23:
                        _forwarService.Forward3_1();
                        return Ok();
                    case 24:
                        _forwarService.Forward3_2();
                        return Ok();
                    case 25:
                        _forwarService.Forward4();
                        return Ok();
                }
                return Ok();
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", "Error", new { message = ex.Message });
            };
            //_forwarService.Forward1();


            //    return RedirectToAction("Index", "Configuration", new {lacName = lacName});
        }

    }
}
