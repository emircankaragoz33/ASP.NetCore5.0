using Microsoft.AspNetCore.Http;

namespace YazilimDanismanlik.Areas.Admin.Models
{
    public class ServiceViewModel
    {
        public string Name { get; set; }
        public string Description { get; set; } 
        public IFormFile picture { get; set; }
       
    }
}
