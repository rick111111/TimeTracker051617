using Microsoft.EntityFrameworkCore;

namespace TimeTracker051617.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<TimeSlice> TimeSlices { get; set; }
    }
}