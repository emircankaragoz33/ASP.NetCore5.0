using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL.Mapping
{
    public class ContactMap : IEntityTypeConfiguration<Contact>
    {
        public void Configure(EntityTypeBuilder<Contact> builder)
        {
            builder.HasKey(C => C.MessageId);
            builder.Property(c => c.GonderenAd).HasMaxLength(50);
            builder.Property(c => c.Mesaj).HasMaxLength(200);
            builder.Property(c => c.Email).HasMaxLength(40);
            builder.Property(c => c.Telefon).HasMaxLength(20);
  
        }
    }
}
