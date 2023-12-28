using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Threading.Tasks;
using YazilimDanismanlik.Models;

namespace YazilimDanismanlik.Controllers
{
    public class ProfileController : Controller
    {
        

        private readonly UserManager<WebUser> _userManager;

        public ProfileController(UserManager<WebUser> userManager)
        {
                _userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);

            ProfileViewModel profileViewModel = new ProfileViewModel();

            profileViewModel.UserName = values.UserName;
            profileViewModel.Name = values.Name;
            profileViewModel.Surname = values.Surname;
            profileViewModel.ProfileImg = values.KucukFotograf;
            

          
          
            return View(profileViewModel);
        }




        [HttpPost]
        public async Task<IActionResult> Index(ProfileViewModel profileViewModel)
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);

            if (profileViewModel.UploadProfile != null)
            {
                var resource = Directory.GetCurrentDirectory();
                var extension = Path.GetExtension(profileViewModel.UploadProfile.FileName);
                var imagename = Guid.NewGuid() + extension;
                var savelocation = resource + "/wwwroot/memberImage/" + imagename;
                var stream = new FileStream(savelocation, FileMode.Create);

                await profileViewModel.UploadProfile.CopyToAsync(stream);
                values.KucukFotograf = imagename;

            }
            
            values.UserName = profileViewModel.UserName;
            values.Name = profileViewModel.Name;
            values.Surname = profileViewModel.Surname;
            values.PasswordHash = _userManager.PasswordHasher.HashPassword(values, profileViewModel.NewPassword);


            var result = await _userManager.UpdateAsync(values);

            if (result.Succeeded)
            {
                RedirectToAction("Index", "Anasayfa");
            }

            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError("", item.Description);
                }
            }

            return View();
        }
    }
}
