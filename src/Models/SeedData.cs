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
                        Duration = TimeSpan.FromMinutes(15),
                        Category = "Internet"
                    },
                    new TimeSlice
                    {
                        Duration = TimeSpan.FromMinutes(25),
                        Category = "Coding"
                    });

                context.SaveChanges();
            }
        }
    }
}
