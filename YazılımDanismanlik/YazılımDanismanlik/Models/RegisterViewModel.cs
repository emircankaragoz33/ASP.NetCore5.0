using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace YazilimDanismanlik.Models
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Lütfen bir kullanıcı adı giriniz.")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Lütfen adınızı giriniz.")]
        public string Name { get; set; }


        [Required(ErrorMessage = "Lütfen Soyadınızı giriniz.")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Lütfen Tel No giriniz.")]
        public string TelefonNo { get; set; }

        public string UzmanlikAlan { get; set; }
        [Required(ErrorMessage = "Lütfen şifre giriniz.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Lütfen şifreyi tekrar giriniz.")]
        [Compare("Password", ErrorMessage = "Şifreler aynı olmak zorundadır.")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Lütfen bir mail adresi giriniz.")]
        public string Mail { get; set; }

        [Required(ErrorMessage = "Lütfen bir görsel yükleyiniz.")]
        public string ImageUrl { get; set; }


        public IFormFile Picture { get; set; }

    }
}
