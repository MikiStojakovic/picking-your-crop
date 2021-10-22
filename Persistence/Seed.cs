using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;

namespace Persistence
{
    public class Seed
    {
        public static async Task SeedData(DataContext context)
        {
            if (context.Activities.Any()) return;
            
            var activities = new List<Activity>
            {
                new Activity
                {
                    Title = "Kruske viljamovke",
                    Date = DateTime.Now.AddMonths(-2),
                    Description = "Pozivam ljude da samostalno uberu kruske viljamovke sa moje parcele. Ima 7 stabala i oko 400 kg.",
                    Category = "Voće",
                    City = "Beocin",
                    Venue = "Rakovac",
                    Price = 20,
                    Unit = "kilogram",
                    Currency = "RSD"
                },
                new Activity
                {
                    Title = "Jabuke zlatni delises",
                    Date = DateTime.Now.AddMonths(-1),
                    Description = "Samostalna berba jabuka zlatni delises. 30 stabala i oko 1t jabuka. Jabuke nisu nikad prskane. ",
                    City = "Irig",
                    Venue = "Krušedol",
                    Category = "Voće",
                    Price = 50,
                    Unit = "kilogram",
                    Currency = "RSD"
                },
                new Activity
                {
                    Title = "Crvena paprika",
                    Date = DateTime.Now.AddMonths(1),
                    Description = "Samostalna berba crvene paprike. U pitanju je paprika slonovo uvo i nalazi se na njivi od 1 hektar. Procena je da ima 3t.",
                    City = "Zrenjanin",
                    Venue = "Lukićevo",
                    Category = "Povrće",
                    Price = 100,
                    Unit = "kilogram",
                    Currency = "RSD"
                }
            };

            await context.Activities.AddRangeAsync(activities);
            await context.SaveChangesAsync();
        }
    }
}