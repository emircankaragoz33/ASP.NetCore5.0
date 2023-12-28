using BL.Concrete;
using DAL.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace YazilimDanismanlik.ViewComponents.Shared
{
    public class AdminnavbarViewComponent : ViewComponent
    {
        ContactManager contactManager = new ContactManager(new ContactDal());
        public IViewComponentResult Invoke()
        {
           var values = contactManager.TGetList();
            return View("adminnavbar",values);
        }
    }
}
