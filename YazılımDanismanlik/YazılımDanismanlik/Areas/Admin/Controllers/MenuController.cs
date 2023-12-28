using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace YazilimDanismanlik.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "admin")]
    public class MenuController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
