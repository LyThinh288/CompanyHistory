
using Microsoft.AspNetCore.Mvc;

namespace CompanyHistory.Controllers
{
    public class HistoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Year(int nam)
        {
            ViewBag.Nam = nam;

            return View();
        }
        public IActionResult Milestones()
        {
            List<string> milestones = new List<string>()
            {
                "2020 - Công ty thành lập",
                "2022 - Công ty có 200 nhân sự ",
                "2026 - Công ty phát triển lên quy mô cả nước"
            };

            ViewData["Milestones"] = milestones;

            return View();
        }
    }
}
