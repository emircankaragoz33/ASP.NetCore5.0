using BL.Concrete;
using DAL.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;
using YazilimDanismanlik.Areas.Admin.Models;

namespace YazilimDanismanlik.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "admin")]
    public class ServiceController : Controller
    {
       
        ServiceManager serviceManager = new ServiceManager(new ServiceDal());
        [HttpGet]
        public IActionResult Index()
        {
            var values = serviceManager.TGetList();
            return View(values);
        }

        public IActionResult DeleteService(int id)
        {
            var value = serviceManager.TGetById(id);
            serviceManager.TDelete(value);
            return RedirectToAction("Index", "Anasayfa");
        }

        [HttpGet]
        public IActionResult AddService()
        {
            return View();
        }

        [HttpPost]
        public async Task <IActionResult> AddService(ServiceViewModel p)
        {
            Service service = new Service()
            {
                ServiceName = p.Name,
                ServiceDescription = p.Description,
                ServiceImage = p.picture.FileName
            };

            if (p.picture != null)
            {
                var projekaynak = Directory.GetCurrentDirectory();
                var uzanti = Path.GetExtension(p.picture.FileName);
                var imagename = Guid.NewGuid() + uzanti;
                var kayityeri = projekaynak + "/wwwroot/serviceimages/" + imagename;
                var stream = new FileStream(kayityeri, FileMode.Create);

                await p.picture.CopyToAsync(stream);

                service.ServiceImage = imagename;

            }

       

            serviceManager.TAdd(service);
            return RedirectToAction("Index", "Anasayfa");
        }
    }
}
