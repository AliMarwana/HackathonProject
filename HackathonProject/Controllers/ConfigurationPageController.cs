using HackathonProject.Models;
using HackathonProject.NewFolder;
using HackathonProject.Services;
using Microsoft.AspNetCore.Mvc;

namespace HackathonProject.Controllers
{
    public class ConfigurationPageController : Controller
    {
        private readonly GVariablesService _variablesService;
        private readonly LacService _lacService;
        
        public ConfigurationPageController(GVariablesService variablesService, LacService lacService)
        {
            _variablesService = variablesService;
            _lacService = lacService;
        }
        public IActionResult Index()
        {
            
            return View();
        }
        public IActionResult Details(string lacName)
        {
            LacInfo lacInfo = _lacService.GetSpecificLacInfo(lacName);
            return View(lacInfo);
        }
    }
}
