using Microsoft.AspNetCore.Mvc;

namespace HackathonProject.Controllers
{
    public class LacController : Controller
    {
       
        public IActionResult Index()
        {
            return View();
        }
    }
}
