using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace EntityLayer.Concrete
{
    public partial class Service
    {
        [Key]
        public int ServiceId { get; set; }
        public string ServiceName { get; set; }
        public string ServiceImage { get; set; }
        public string ServiceDescription { get; set; }
    }
}
