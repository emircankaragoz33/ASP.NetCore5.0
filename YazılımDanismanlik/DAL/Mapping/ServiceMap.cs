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
    public class ServiceMap : IEntityTypeConfiguration<Service>
    {
        public void Configure(EntityTypeBuilder<Service> builder)
        {
            builder.HasKey(C => C.ServiceId);
            builder.Property(C => C.ServiceName).HasMaxLength(50);
            builder.Property(C => C.ServiceDescription).HasMaxLength(150);
        }
    }
}
