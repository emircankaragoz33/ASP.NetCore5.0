using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class WebRole : IdentityRole<int>
    {
        public string RolTanimi { get; set; }
        public DateTime RolOlusturmaTarihi { get; set; }

    }
}
