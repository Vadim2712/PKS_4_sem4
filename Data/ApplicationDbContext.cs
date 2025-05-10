using Microsoft.EntityFrameworkCore;
using TouristGuideApp.Models;

namespace TouristGuideApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<City> Cities { get; set; }
        public DbSet<Attraction> Attractions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Здесь можно добавить дополнительную конфигурацию Fluent API, если потребуется
            // Например, для более сложных связей или ограничений.

            // Пример сидинга данных (можно вынести в отдельный класс)
            modelBuilder.Entity<City>().HasData(
                new City { Id = 1, Name = "Москва", Region = "Центральный ФО", Population = 12655050, PhotoImageUrl = "https://www.m24.ru/b/d/nBkSUhL2hFggnsq2JL6BrNOp2Z318Ji-mifGnuWR9mOBdDebBizCnTY8qdJf6ReJ58vU9meMMok3Ee2nhSR6ISeO9G1N_wjJ=5lZzUN6kbqlY9eReZPSL0w.jpg", CoatOfArmsImageUrl = "https://models.rsbis.com/storage/makets/preview/resize_600x600/3d/90/3d904bff520e868051d015d0f19af950.jpeg", History = "Москва — столица Российской Федерации, город федерального значения..." },
                new City { Id = 2, Name = "Санкт-Петербург", Region = "Северо-Западный ФО", Population = 5384342, PhotoImageUrl = "https://sun9-32.userapi.com/s/v1/ig2/AHWNTHWw4_l3RnxAWQSEKXCAiaFeGS5MAMVvaKx_MIHJ4bt84fyXaURw9IVLvHkNAlFw8_kc2LdgHNDUWz_qAp4x.jpg?quality=95&as=32x32,48x48,72x72,108x108,160x160,240x240,360x360,480x480,540x540,640x640,720x720,1080x1080&from=bu&cs=1080x1080", CoatOfArmsImageUrl = "https://assets.compmechlab.ru/clients/spb.png", History = "Санкт-Петербург — второй по численности населения город России..." }
            );

            modelBuilder.Entity<Attraction>().HasData(
                new Attraction { Id = 1, CityId = 1, Name = "Красная площадь", Description = "Главная площадь Москвы.", PhotoImageUrl = "https://ak.picdn.net/shutterstock/videos/1087836581/thumb/1.jpg", History = "Исторически важное место...", OpeningHours = "Круглосуточно (кроме мероприятий)", TicketPrice = null },
                new Attraction { Id = 2, CityId = 1, Name = "Большой театр", Description = "Один из крупнейших в России и один из самых значительных в мире театров оперы и балета.", PhotoImageUrl = "https://avatars.mds.yandex.net/i?id=db4e63cbe4ea7456176839f9b2247153_l-5443655-images-thumbs&n=13", History = "Основан в 1776 году...", OpeningHours = "Согласно афише", TicketPrice = 1500m },
                new Attraction { Id = 3, CityId = 2, Name = "Эрмитаж", Description = "Один из крупнейших и самых значительных художественных и культурно-исторических музеев России и мира.", PhotoImageUrl = "https://avatars.dzeninfra.ru/get-zen_doc/8080662/pub_63e8dbe7d8076318c17e3005_63e8dbecd8076318c17e3170/scale_1200", History = "Основан в 1764 году...", OpeningHours = "11:00 – 18:00 (выходной - понедельник)", TicketPrice = 500m }
            );
        }
    }
}