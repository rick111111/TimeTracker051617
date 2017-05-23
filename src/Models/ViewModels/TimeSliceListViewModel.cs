using System.Collections.Generic;

namespace TimeTracker051617.Models.ViewModels
{
    public class TimeSliceListViewModel
    {
        public IEnumerable<TimeSlice> TimeSlices { get; set; }

        public PagingInfo PagingInfo { get; set; }
    }
}
