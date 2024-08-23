using HackathonProject.DefaultConfiguration;
using HackathonProject.Models;
using HackathonProject.NewFolder;
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
    }
}
