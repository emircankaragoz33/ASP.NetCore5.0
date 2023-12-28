using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class WebUser : IdentityUser<int>
    {
       
        public string Name { get; set; }
        public string Surname { get; set; }
        public string UzmanlikAlan { get; set; }
        public string KucukFotograf { get; set; }
        public string BuyukFotograf { get; set; }

   
    }
}
