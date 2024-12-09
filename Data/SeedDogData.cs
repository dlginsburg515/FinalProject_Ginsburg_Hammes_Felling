using Microsoft.EntityFrameworkCore;
using FinalProject_DG_CH_BF.Models;

namespace FinalProject_DG_CH_BF.Data
{
    public class SeedDogData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using var context = new FinalProject_DG_CH_BFContext (
                serviceProvider.GetRequiredService<
                    DbContextOptions<FinalProject_DG_CH_BFContext>>());
                   

            if (context == null || context.Dog == null)
            {
                throw new NullReferenceException(
                    "Null BlazorBookContext or Book DbSet");
            }

            if (context.Dog.Any())
            {
                return;
            }

            context.Dog.AddRange(
                new Dog
                {
                    
                },

                new Dog
                {
                    
                });

            context.SaveChanges();
        }

    }
}
