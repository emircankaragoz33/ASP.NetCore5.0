using BL.Concrete;
using DAL.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace YazilimDanismanlik.ViewComponents.Anasayfa
{
    
    public class ServicesViewComponent : ViewComponent
    {
        ServiceManager serviceManager = new ServiceManager(new ServiceDal());
        public IViewComponentResult Invoke()
        {
            var values = serviceManager.TGetList();
            return View("Services",values);
        }
    }
}
