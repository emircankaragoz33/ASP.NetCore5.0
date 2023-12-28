using DAL.Context;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;

namespace YazilimDanismanlik.DataSeeding
{
    public static class DataSeeding
    {

        public static void Seed(IApplicationBuilder app)
        {
            var scope = app.ApplicationServices.CreateScope();
            var context = scope.ServiceProvider.GetService<YazilimContext>();
            context.Database.Migrate();

            if (context.Head.Count() == 0 && context.About.Count() == 0)
            {
                context.Head.Add(new Head
                {
                    
                    KarsilamaAciklama = "Yazılım Kursumuza hoşgeldiniz.",
                    KarsilamaBaslik = "Emircan Karagöz Yazılım Kursu"
                });

                context.About.Add(new About
                {
                  
                    AboutAciklama = "10 Farklı alandan 10 uzman eğitmenimizle sizler için hazırız!",
                    AboutBaslik = "Bizimle beraber en iyi verimi alacaksınız ;  Detaylar için kaydırın."
                });

                context.Services.Add(new Service
                {
                    
                    ServiceDescription = "Baştan sona c# müfredatı - EntityFramework Core , ASP net Core",
                    ServiceImage = "031d0004-9b47-40ef-9c4c-99f7c9e4258d.png",
                    ServiceName = "C# Baştan sona eğitim programı"
                });


                context.Roles.Add(new WebRole
                {
                  
                    Name = "admin",
                    RolTanimi = "Tam yetki kontrol.",


                });

                context.Roles.Add(new WebRole
                {
                   
                    Name = "Eğitmen",
                    RolTanimi = "Şirketimizin eğitim görevlisi.",


                });


                context.SaveChanges();
            }


        }
    }
}
