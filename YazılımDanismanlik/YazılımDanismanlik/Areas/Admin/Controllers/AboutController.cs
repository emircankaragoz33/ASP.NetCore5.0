using BL.Concrete;
using DAL.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace YazilimDanismanlik.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    [Authorize(Roles ="admin")]
    public class AboutController : Controller
    {
        AboutManager aboutManager = new AboutManager(new AboutDal());

        [HttpGet]
        public IActionResult AboutGuncelle()
        {
            var values = aboutManager.TGetList().FirstOrDefault();
            return View(values);
        }


        public IActionResult AboutGuncelle(About about)
        {

            aboutManager.TUpdate(about);
            return RedirectToAction("Index" ,"Anasayfa");
        }
    }
}
