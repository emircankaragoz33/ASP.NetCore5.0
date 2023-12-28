using Microsoft.AspNetCore.Mvc;

namespace YazilimDanismanlik.ViewComponents.Anasayfa
{
    public class ErrorPageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Index404()
        {
            return View();
        }
    }
}
