using Microsoft.AspNetCore.Mvc;

namespace HackathonProject.Controllers
{
    public class ConfigurationPageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
