using HackathonProject.Models;
using HackathonProject.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HackathonProject.Controllers
{
    public class DashboardController : Controller
    {
        private DashbordModelService _dashbordService;
        public DashboardController(DashbordModelService dashboardService)
        {
            _dashbordService = dashboardService;
            
        }
        public IActionResult Index()
        {
            try
            {
                DashbordModel model = _dashbordService.GetDashbordProperties();
                return View(model);
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", "Error", new { message = ex.Message });
            };
        }
    }
}
