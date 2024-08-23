using HackathonProject.Models;
using HackathonProject.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace HackathonProject.Controllers
{
    public class ErrorController : Controller
    {
        
        public IActionResult Index(string message)
        {
            ErrorContentViewModel vm = new ErrorContentViewModel { Message = message };
            return View(vm);
        }
    }
}
