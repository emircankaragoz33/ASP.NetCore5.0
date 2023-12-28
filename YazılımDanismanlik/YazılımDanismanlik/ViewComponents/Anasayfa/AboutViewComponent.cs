using BL.Concrete;
using DAL.Abstract;
using DAL.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace YazilimDanismanlik.ViewComponents.Anasayfa
{
    public class AboutViewComponent : ViewComponent
    {
        AboutManager aboutManager = new AboutManager(new AboutDal());
        public IViewComponentResult Invoke()
        {
            var values = aboutManager.TGetList();
            return View("About" , values);
        }
    }
}
