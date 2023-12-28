using BL.Concrete;
using DAL.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace YazilimDanismanlik.ViewComponents.Anasayfa
{
    public class HeadViewComponent : ViewComponent
    {
        HeadManager headManager = new HeadManager(new HeadDal());
        public IViewComponentResult Invoke()
        {
          var values =   headManager.TGetList();
            return View("Head" , values);
        }
    }
}
