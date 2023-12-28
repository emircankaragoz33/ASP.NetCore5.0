using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace YazilimDanismanlik.ViewComponents.Anasayfa
{
    public class TeamViewComponent : ViewComponent
    {
        private readonly UserManager<WebUser> _userManager;

        public TeamViewComponent(UserManager<WebUser> userManager)
        {
               _userManager = userManager;
        }

        public async Task <IViewComponentResult> InvokeAsync()
        {
            var egitmenler = await _userManager.GetUsersInRoleAsync("Eğitmen");
            return View("team",egitmenler);
        }
    }
}
