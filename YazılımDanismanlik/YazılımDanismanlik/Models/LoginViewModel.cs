using System.ComponentModel.DataAnnotations;

namespace YazilimDanismanlik.Models
{
    public class LoginViewModel
    {
        [Display(Name = "Kullanıcı adınız")]
        [Required(ErrorMessage = "Kullanıcı adınızı giriniz!!!")]
        public string UserName { get; set; }

        [Display(Name = "Şifreniz")]
        [Required(ErrorMessage = "Şifreyi giriniz!!")]
        public string password { get; set; }
    }
}
