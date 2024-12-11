using Microsoft.EntityFrameworkCore;
using FinalProject_DG_CH_BF.Models;

namespace FinalProject_DG_CH_BF.Data;

public class SeedDogData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using var context = new FinalProject_DG_CH_BFContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<FinalProject_DG_CH_BFContext>>());


        if (context == null || context.Dog == null)
        {
            throw new NullReferenceException(
                "Null Context or DbSet");
        }

        if (context.Dog.Any())
        {
            return;
        }

        context.Dog.AddRange(
            new Dog
            {

                Name = "Doug",
                DateArrived = new DateOnly(2024, 04, 12),
                Weight = 40,
                Height = 20,
                Color = "Black",
                Breed = "Scottish Terrier",
                Gender = "Male",
                Age = 6,
                Description = "Energetic, friendly, does not bark.",
                HealthStatus = "Up to date on all vaccines. No health issues.",
                GoodWithKids = true,
                GoodWithDogs = true,
                GoodWithCats = true, 
                imageName = "Doug.jpg"


            },

             new Dog
             {

                 Name = "Barbara",
                 DateArrived = new DateOnly(2024, 02, 20),
                 Weight = 70,
                 Height = 28,
                 Color = "Black, Brown, White",
                 Breed = "Beagle",
                 Gender = "Female",
                 Age = 7,
                 Description = "Loves attention and long walks!",
                 HealthStatus = "Up to date on all vaccines. Gets blisters easily.",
                 GoodWithKids = true,
                 GoodWithDogs = true,
                 GoodWithCats = false,
                 imageName = "Barbara.jpg"


             },

             new Dog
             {

                 Name = "Doris",
                 DateArrived = new DateOnly(2024, 08, 08),
                 Weight = 90,
                 Height = 34,
                 Color = "White, Black dots",
                 Breed = "Dalmatian",
                 Gender = "Female",
                 Age = 3,
                 Description = "Hyper, lovable, great at fetch!",
                 HealthStatus = "Up to date on all vaccines. Blind in left eye.",
                 GoodWithKids = true,
                 GoodWithDogs = false,
                 GoodWithCats = false,
                 imageName = "Doris.jpg"


             },

             new Dog
             {

                 Name = "Henry",
                 DateArrived = new DateOnly(2023, 01, 09),
                 Weight = 40,
                 Height = 20,
                 Color = "Brown",
                 Breed = "Greyhound",
                 Gender = "Male",
                 Age = 4,
                 Description = "Independent, confident, and well-mannered.",
                 HealthStatus = "Up to date on all vaccines. Limp on his back-left leg.",
                 GoodWithKids = true,
                 GoodWithDogs = true,
                 GoodWithCats = true,
                 imageName = "Henry.jpg"


             },

               new Dog
               {

                   Name = "Buford",
                   DateArrived = new DateOnly(2023, 06, 17),
                   Weight = 150,
                   Height = 40,
                   Color = "Brown, White",
                   Breed = "Saint Bernard",
                   Gender = "Male",
                   Age = 6,
                   Description = "Stylish, sluggish, and slobbery!",
                   HealthStatus = "Up to date on all vaccines. Microchipped.",
                   GoodWithKids = true,
                   GoodWithDogs = true,
                   GoodWithCats = false,
                   imageName = "Buford.jpg"


               },

            new Dog
            {
                Name = "Terri",
                DateArrived = new DateOnly(2024, 11, 06),
                Weight = 60,
                Height = 22,
                Color = "Brown, White",
                Breed = "Bulldog",
                Gender = "Female",
                Age = 10,
                Description = "Reliable, laidback, and affectionate.",
                HealthStatus = "Up to date on all vaccines. Has issues with her back legs.",
                GoodWithKids = true,
                GoodWithDogs = true,
                GoodWithCats = true,
                imageName = "Terri.jpg"
            });

        context.SaveChanges();
    }

}