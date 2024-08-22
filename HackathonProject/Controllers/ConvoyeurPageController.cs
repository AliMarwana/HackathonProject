using Microsoft.AspNetCore.Mvc;

namespace HackathonProject.Controllers
{
    public class ConvoyeurPageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
