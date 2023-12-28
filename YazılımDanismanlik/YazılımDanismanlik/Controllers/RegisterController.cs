using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System;
using System.Threading.Tasks;
using YazilimDanismanlik.Models;

namespace YazilimDanismanlik.Controllers
{
    
    [AllowAnonymous]
    public class RegisterController : Controller
    {
        private readonly UserManager<WebUser> _userManager;

        public RegisterController(UserManager<WebUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(new RegisterViewModel());
        }

        [HttpPost]
        public async Task<IActionResult> Index(RegisterViewModel p)
        {

            WebUser webUser = new WebUser()
            {
                Name = p.Name,
                Surname = p.Surname,
                Email = p.Mail,
                UserName = p.UserName,
                KucukFotograf = p.Picture.FileName,
                PhoneNumber = p.TelefonNo,
                UzmanlikAlan = p.UzmanlikAlan,

            };


            if (p.Password == p.ConfirmPassword)
            {



                if (p.Picture != null)
                {
                    var resource = Directory.GetCurrentDirectory();
                    var extension = Path.GetExtension(p.Picture.FileName);
                    var imagename = Guid.NewGuid() + extension;
                    var savelocation = resource + "/wwwroot/memberImage/" + imagename;
                    var stream = new FileStream(savelocation, FileMode.Create);

                    await p.Picture.CopyToAsync(stream);

                    webUser.KucukFotograf = imagename;
                }

                var result = await _userManager.CreateAsync(webUser, p.Password);


                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Anasayfa");
                }

                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
            }

            return View();


        }




    }
}

