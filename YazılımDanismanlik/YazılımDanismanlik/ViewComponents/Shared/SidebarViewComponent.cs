using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace YazilimDanismanlik.ViewComponents.Shared
{
    public class SidebarViewComponent : ViewComponent
    {
        private readonly UserManager<WebUser> _userManager;
        private readonly SignInManager<WebUser> _signInManager;
      

        public SidebarViewComponent(UserManager<WebUser> userManager)
        {
           _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var admin = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.AdSoyad = admin.Name + " " + admin.Surname;
            ViewBag.Fotograf = admin.KucukFotograf;
            ViewBag.Yetki = "admin";


            return View("sidebar",admin);
        }

      
    }
}
