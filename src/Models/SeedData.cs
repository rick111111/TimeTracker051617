using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace TimeTracker051617.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            ApplicationDbContext context = app.ApplicationServices
                .GetRequiredService<ApplicationDbContext>();

            if (!context.TimeSlices.Any())
            {
                context.TimeSlices.AddRange(
                    new TimeSlice
                    {
                        Id = 1,
                        Duration = TimeSpan.FromMinutes(15),
                        Category = "Internet"
                    },
                    new TimeSlice
                    {
                        Id = 2,
                        Duration = TimeSpan.FromMinutes(25),
                        Category = "Coding"
                    },
                    new TimeSlice
                    {
                        Id = 3,
                        Duration = TimeSpan.FromMinutes(40),
                        Category = "Happy Time"
                    });

                context.SaveChanges();
            }
        }
    }
}
