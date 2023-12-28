using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using YazilimDanismanlik.Models;

namespace YazilimDanismanlik.Controllers
{
    
    [AllowAnonymous]
    public class LoginController : Controller
    {
        private readonly SignInManager<WebUser> _signInManager;

        public LoginController(SignInManager<WebUser> signInManager)
        {
            _signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Index(LoginViewModel p)
        {

            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(p.UserName, p.password, true, true);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Anasayfa");
                }

                else
                {
                    ModelState.AddModelError("", "Hatalı kullanıcı adı veya şifre");
                }
            }

            else
            {

            }



            return View();
        }

        
    }
}
