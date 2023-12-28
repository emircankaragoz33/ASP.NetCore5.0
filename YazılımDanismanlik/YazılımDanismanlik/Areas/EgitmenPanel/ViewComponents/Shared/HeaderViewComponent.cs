using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace YazilimDanismanlik.Areas.EgitmenPanel.ViewComponents.Shared
{


    public class HeaderViewComponent : ViewComponent
    {

        private readonly UserManager<WebUser> _userManager;

        public HeaderViewComponent(UserManager<WebUser> userManager)
        {
            _userManager = userManager;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var egitmen = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.Ad = egitmen.Name + " " + egitmen.Surname;
            return View("Header",egitmen);
        }
    }
}
