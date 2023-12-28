using BL.Concrete;
using DAL.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace YazilimDanismanlik.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "admin")]
    public class HeadController : Controller
    {
        HeadManager headManager = new HeadManager(new HeadDal());

        [HttpGet]
        public IActionResult HeadGuncelle()
        {
            var value = headManager.TGetList().FirstOrDefault();
            return View(value);
        }

        public IActionResult HeadGuncelle(Head head)
        {
            headManager.TUpdate(head);
            return RedirectToAction("Index", "Anasayfa");
        }
    }
}
