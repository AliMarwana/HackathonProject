using Microsoft.AspNetCore.Mvc;

namespace HackathonProject.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
