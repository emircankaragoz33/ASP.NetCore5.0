using BL.Concrete;
using DAL.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YazilimDanismanlik.Areas.EgitmenPanel.Controllers
{
    [Area("EgitmenPanel")]
    public class Sistem : Controller
    {
        private readonly UserManager<WebUser> _userManager;
        EgitmenContactManager egitmenContactManager = new EgitmenContactManager(new EgitmenContactDal());

        public Sistem(UserManager<WebUser> userManager)
        {
            _userManager = userManager;   
        }



        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var egitmen = await _userManager.FindByNameAsync(User.Identity.Name);
            List <EgitmenContact> values = egitmenContactManager.TGetList().Where(c => c.AliciEgitmen == egitmen.Name + " " + egitmen.Surname && c.GonderenUye == "Sistem").ToList();
            return View(values);
        }
    }
}
