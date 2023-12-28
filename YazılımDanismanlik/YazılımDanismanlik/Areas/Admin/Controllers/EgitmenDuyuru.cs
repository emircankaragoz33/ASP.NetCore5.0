using BL.Concrete;
using DAL.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Cryptography.Xml;

namespace YazilimDanismanlik.Areas.Admin.Controllers
{
    [Area("admin")]
    [Authorize(Roles = "admin")]
    [Authorize]
    public class EgitmenDuyuru : Controller
    {
      
        EgitmenContactManager egitmenContactManager = new EgitmenContactManager(new EgitmenContactDal());
        //private readonly UserManager<WebUser> _userManager;

        //public EgitmenDuyuru(UserManager<WebUser> userManager)
        //{
        //    _userManager = userManager;
        //}

        //public EgitmenDuyuru()
        //{
        //    string gonderen = "Sistem";
        //}

        [HttpGet]
        public IActionResult Index()
        {
          
  
            return View();
        }

      
        public IActionResult Index(EgitmenContact egitmenContact)
        {



            egitmenContactManager.TAdd(egitmenContact);



            return RedirectToAction("Index", "Anasayfa");
        }
    }
}
