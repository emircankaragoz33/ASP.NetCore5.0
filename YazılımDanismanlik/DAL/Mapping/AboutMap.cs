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
    public class AboutMap : IEntityTypeConfiguration<About>
    {
        public void Configure(EntityTypeBuilder<About> builder)
        {
            builder.HasKey(c => c.AboutId);
            builder.Property(c=>c.AboutBaslik).HasMaxLength(50);
            builder.Property(c=>c.AboutAciklama).HasMaxLength(100);
           
        }
    }
}
