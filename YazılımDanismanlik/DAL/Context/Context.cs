using DAL.Mapping;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


namespace DAL.Context
{
    public class YazilimContext : IdentityDbContext<WebUser, WebRole, int>
    {
        public DbSet<About> About { get; set; }
        public DbSet<Contact> Contact { get; set; }
        public DbSet<Head> Head { get; set; }
        public DbSet<Service> Services { get; set; }
    
        public DbSet<EgitmenContact> EgitmenContacts { get; set; }

    


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=DbYazilimDanismanlik;Trusted_Connection=True;");
        }

        //protected override void OnModelCreating(ModelBuilder builder)
        //{
         
        //    //builder.Entity<Head>().HasData(
        //    //    new Head()
        //    //    {
        //    //        HeadId = 1,
        //    //        KarsilamaAciklama = "Yazılım Koçluk Sistemi'ne hoşgeldiniz!",
        //    //        KarsilamaBaslik = "Yazılım Koçluk"

        //    //    }
        //    //    );

        //    //builder.Entity<About>().HasData(
        //    //    new About()
        //    //    {
        //    //        AboutId = 1,
        //    //        AboutBaslik = "Biz deneyimli ve tecrübeli yazılımcılardan oluşan doğru rotanızı bulmanız için bir araya gelmiş eğitmenleriz.",
        //    //        AboutAciklama = "Ekibimizi ve hizmetlerimizi görmek için aşağıya inin."

        //    //    });

        //    //builder.Entity<Service>().HasData(
        //    //    new Service()
        //    //    {
        //    //        ServiceId = 1,
        //    //        ServiceName = "Javascript",
        //    //        ServiceImage = "6ae7727b-1ee7-4a13-9be5-ee92a12e5746.png",
        //    //        ServiceDescription = "60 Saatlik Javascript müfredatı ile sizi ileriye taşıyoruz."
        //    //    });
        //}

    }
}
