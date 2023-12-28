using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class EgitmenContact 
    {
        [Key]
        public int MessageID { get; set; }
        public string AliciEgitmen { get; set; }
        public string GonderenUye { get; set; }
        public string Message { get; set; }
        public DateTime Tarih { get; set; }

    }
}
