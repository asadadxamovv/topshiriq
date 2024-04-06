using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace topshiriq
{
    public class TalabaConfiguration : IEntityTypeConfiguration<Talaba>
    {
        public void Configure(EntityTypeBuilder<Talaba> builder)
        {
            builder.HasData(
     new Talaba
     {
         Id = 1,
         Ism = "Ali",
         Yosh = 25,
         Familiya = "Alijonov",
         Shahar = "Toshkent"

     },
     new Talaba
     {
         Id = 2,
         Ism = "jahon",
         Yosh = 24,
         Familiya = "Akbarov",
         Shahar = "Qashqadaryo"

     },
     new Talaba
     {
         Id = 3,
         Ism = "Shoxrux",
         Yosh = 25,
         Familiya = "Shodiyov",
         Shahar = "Toshkent"
     },
     new Talaba
     {
         Id = 4,
         Ism = "Elbek",
         Yosh = 27,
         Familiya = "Olimov",
         Shahar = "Namangan"
     },
     new Talaba
     {
         Id = 5,
         Ism = "Boxodir",
         Yosh = 28,
         Familiya = "Elmurodov",
         Shahar = "Tashkent"
     },
     new Talaba
     {
         Id = 6,
         Ism = "Javohir",
         Yosh = 30,
         Familiya = "Toxtaboyev",
         Shahar = "Andjon"
     },
     new Talaba
     {
         Id = 7,
         Ism = "Jon",
         Yosh = 31,
         Familiya = "Week",
         Shahar = "London"
     });
        }
    }
}
