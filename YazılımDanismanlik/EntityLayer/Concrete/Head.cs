using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace EntityLayer.Concrete
{
    public partial class Head
    {
        [Key]
        public int HeadId { get; set; }
        public string KarsilamaBaslik { get; set; }
        public string KarsilamaAciklama { get; set; }
    }
}
