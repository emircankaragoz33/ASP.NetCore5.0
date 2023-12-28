using BL.Concrete;
using DAL.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using YazilimDanismanlik.Models;


namespace YazılımDanismanlik.Controllers
{
    [AllowAnonymous]
    public class AnasayfaController : Controller
    {
        ContactManager contactManager = new ContactManager(new ContactDal());
        private readonly UserManager<WebUser> _userManager;
        private readonly SignInManager<WebUser> _signInManager;

        public AnasayfaController(SignInManager<WebUser> signInManager , UserManager<WebUser> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }




        [HttpGet]
        public async Task <IActionResult> Index()
        {
        

          return View();
           
        }


        public async Task<IActionResult> SignOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Anasayfa");
        }


        public PartialViewResult MesajGonder(Contact message)
        {
            contactManager.TAdd(message);
            return PartialView();
        }
    }
}
