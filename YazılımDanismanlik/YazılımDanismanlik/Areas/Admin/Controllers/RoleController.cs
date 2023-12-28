using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;
using YazilimDanismanlik.Models;

namespace YazilimDanismanlik.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "admin")]
    public class RoleController : Controller
    {
        private readonly RoleManager<WebRole> _roleManager;


        public RoleController(RoleManager<WebRole> roleManager)
        {
            _roleManager = roleManager;
        }

        public IActionResult Index()
        {
            var values = _roleManager.Roles.ToList();

            return View(values);
        }

        public IActionResult CreateRole()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> CreateRole(RoleViewModel rolViewModel)
        {
            IdentityResult result = await _roleManager.CreateAsync(new WebRole()
            {
                Name = rolViewModel.RolAdi,
                RolOlusturmaTarihi = DateTime.Now,
                RolTanimi = rolViewModel.RolTanimi

            });


            if (result.Succeeded)
            {
                ViewBag.RolOlusturma = "Yetki Oluşturma Başarıyla tamamlandı.";
            }

            return RedirectToAction("Index","Anasayfa");
        }

        public async Task<IActionResult> DeleteRole(string id)
        {
            WebRole role = await _roleManager.FindByIdAsync(id);
            IdentityResult result = await _roleManager.DeleteAsync(role);

            if (result.Succeeded)
            {
                ViewBag.RolOlusturma = "Yetki Silindi. ";
            }
            return RedirectToAction("Index", "Anasayfa");
        }

      
    }
}
