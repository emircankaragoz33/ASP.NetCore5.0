using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace YazilimDanismanlik.Areas.Admin.Controllers
{
    [Authorize(Roles ="admin")]
    [Area("Admin")]
    public class TeamController : Controller
    {
        private readonly UserManager<WebUser> _userManager;


        public TeamController(UserManager<WebUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _userManager.GetUsersInRoleAsync("Eğitmen");
            return View(values);
        }
    }
}
