using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using YazilimDanismanlik.Models;

namespace YazılımDanismanlik.ViewComponents.Anasayfa
{
    public class NavbarViewComponent : ViewComponent
    {
        private readonly UserManager<WebUser> _userManager;
        private readonly IdentityUser identityUser; //İPTAL 
        private readonly SignInManager<WebUser> _signInManager;
      

        public NavbarViewComponent( UserManager<WebUser> userManager)
        {
            _userManager = userManager;
        }


       

        public async Task<IViewComponentResult> InvokeAsync()
        {
            if (User.Identity.Name != null)
            {
                var values = await _userManager.FindByNameAsync(User.Identity.Name);
                UserViewModel p = new UserViewModel();
                p.UserRealName = values.Name;
                p.UserRealSurname = values.Surname;
                p.UserImage = values.KucukFotograf;



                ViewBag.KullaniciGorsel = values.KucukFotograf;

                ViewBag.User = "Hoşgeldin:  " + "  " + " (" + p.UserRealName + " " + p.UserRealSurname + ")";
            }

         

            return View("Navbar");

        }
    }
}
