using System.Collections.Generic;

namespace TimeTracker051617.Models
{
    public interface ITimeSliceRepository
    {
        IEnumerable<TimeSlice> TimeSlices { get; }
    }
}
