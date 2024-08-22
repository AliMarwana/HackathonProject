using HackathonProject.NewFolder;
using Microsoft.AspNetCore.Mvc;

namespace HackathonProject.Controllers
{
    public class ConfigurationPageController : Controller
    {
        private readonly GVariablesService _variablesService;
        public ConfigurationPageController(GVariablesService variablesService)
        {
            _variablesService = variablesService;
        }
        public IActionResult Index()
        {
            
            return View();
        }
    }
}
