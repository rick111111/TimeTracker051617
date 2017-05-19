using System.Collections.Generic;

namespace TimeTracker051617.Models
{
    public class EFTimeSliceRepository : ITimeSliceRepository
    {
        private ApplicationDbContext _dbContext;

        public EFTimeSliceRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<TimeSlice> TimeSlices
        {
            get
            {
                return _dbContext.TimeSlices;
            }
        }
    }
}
