using BL.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YazilimDanismanlik.Models;

namespace YazilimDanismanlik.Areas.Admin.Controllers
{
    [Authorize(Roles = "admin")]
    [Area("Admin")]
    public class UserController : Controller
    {
        private readonly UserManager<WebUser> _UserManager;
      
        private readonly RoleManager<WebRole> _webRoleManager;

    
        public UserController(UserManager<WebUser> userManager, RoleManager<WebRole> webRoleManager)
        {
            _UserManager = userManager;
            _webRoleManager = webRoleManager;
        }

        public   IActionResult Index()
        {
            var values = _UserManager.Users.ToList();

            return View(values);
        }

        public IActionResult UyeRollendir()
        {
      


            List<SelectListItem> degerler = (from x in _webRoleManager.Roles.ToList()
                                             select new SelectListItem
                                             {
                                                 Text = x.Name,
                                                 Value = x.Id.ToString()

                                             }).ToList();

            ViewBag.degerler = degerler;



            var values = _UserManager.Users.ToList();
            return View(values);
        }
    }
}
