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
    public class HeadMap : IEntityTypeConfiguration<Head>
    {
        public void Configure(EntityTypeBuilder<Head> builder)
        {
            builder.HasKey(c => c.HeadId);

            builder.Property(c => c.KarsilamaBaslik).HasMaxLength(50);
            builder.Property(c => c.KarsilamaAciklama).HasMaxLength(150);
            builder.Property(c => c.KarsilamaAciklama).HasMaxLength(150);
        }
    }
}
