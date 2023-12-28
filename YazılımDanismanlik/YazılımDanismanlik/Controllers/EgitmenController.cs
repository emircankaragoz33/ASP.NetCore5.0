using BL.Concrete;
using DAL.Concrete;
using DAL.Context;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YazilimDanismanlik.Models;

namespace YazilimDanismanlik.Controllers
{
    public class EgitmenController : Controller
    {
        private readonly UserManager<WebUser> _userManager;
        private readonly RoleManager<WebRole> _roleManager;
        WebUserManager webUserManager = new WebUserManager(new WebUserDal());

        EgitmenContactManager egitmenContactManager = new EgitmenContactManager(new EgitmenContactDal());

        //Projedeki görevli eğitmenleri listelemek amacıyla oluşturuldu.
        //A list of instructors assigned to the project was created.

        public EgitmenController(UserManager<WebUser> userManager , RoleManager<WebRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public async Task <IActionResult> Index()
        {


            var egitmenler = await _userManager.GetUsersInRoleAsync("Eğitmen");

            return View(egitmenler);
        }

        [HttpGet]
        public async Task< IActionResult> EgitmenUlasildi()
        {
            
            return View();
        }

       
        public async Task<IActionResult> EgitmenUlas(int id)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var egitmen = webUserManager.TGetById(id);

            EgitmenContact egitmenContact = new EgitmenContact()
            {
                AliciEgitmen = egitmen.Name + " " + egitmen.Surname,
                GonderenUye = user.Name + " " + user.Surname,
                Message = egitmen.UzmanlikAlan + " " + "alanında eğitim talep etmek istiyorum. Mail Adresim" +
                " " + user.Email + " " + "Telefon numaram : " + user.PhoneNumber,
                Tarih = DateTime.Now
                
            };


            egitmenContactManager.TAdd(egitmenContact);
         

          

            return RedirectToAction("EgitmenUlasildi","Egitmen");
        }


    }
}
