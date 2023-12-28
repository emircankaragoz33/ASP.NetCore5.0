using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace YazilimDanismanlik.Areas.EgitmenPanel.Controllers
{
    [Area("EgitmenPanel")]
    [Authorize]
    [Authorize(Roles = "Eğitmen")]
    public class EgitmenMenu : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
