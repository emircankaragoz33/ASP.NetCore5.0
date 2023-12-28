using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace YazilimDanismanlik.Models
{
    public class ProfileViewModel
    {
        [Required(ErrorMessage = "Lütfen bir kullanıcı adı giriniz.")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Lütfen adınızı giriniz.")]
        public string Name { get; set; }


        [Required(ErrorMessage = "Lütfen Soyadınızı giriniz.")]
        public string Surname { get; set; }

        //public string OldPassword { get; set; }

        public string NewPassword { get; set; }

        [Compare("NewPassword", ErrorMessage = "Şifreler aynı olmak zorundadır.")]
        public string NewPasswordConfirm { get; set; }

        public string ProfileImg { get; set; }
        public IFormFile UploadProfile { get; set; }

    }
}
