using BL.Concrete;
using DAL.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YazilimDanismanlik.Areas.EgitmenPanel.Controllers
{
    [Area("EgitmenPanel")]
    [Authorize]
    [Authorize(Roles = "Eğitmen")]
    public class EgitimTalepleri : Controller
    {
        EgitmenContactManager egitmenContact = new EgitmenContactManager(new EgitmenContactDal());
        private readonly UserManager<WebUser> _userManager;

        public EgitimTalepleri(UserManager<WebUser> userManager)
        {
                _userManager = userManager;
        }
        public async Task<IActionResult> Index()
        {
            
            var egitmen = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.Ad = "Eğitmen " + " " +egitmen.Name + " " + egitmen.Surname;

            List<EgitmenContact> values = egitmenContact.TGetList().Where(c => c.AliciEgitmen == egitmen.Name + " " + egitmen.Surname).ToList();
            return View(values);
        }
    }
}
