using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public partial class Contact
    {
        [Key]
        public int MessageId { get; set; }
        public string GonderenAd { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public string Mesaj { get; set; }
    }
}
