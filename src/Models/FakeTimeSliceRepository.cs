using System;
using System.Collections.Generic;

namespace TimeTracker051617.Models
{
    public class FakeTimeSliceRepository : ITimeSliceRepository
    {
        public IEnumerable<TimeSlice> TimeSlices
        {
            get
            {
                List<TimeSlice> lt = new List<TimeSlice>() {
                    new TimeSlice
                    {
                        Duration = TimeSpan.FromMinutes(15),
                        Category = "Internet"
                    },
                    new TimeSlice
                    {
                        Duration = TimeSpan.FromMinutes(25),
                        Category = "Coding"
                    }
                };

                return lt;
            }
        }
    }
}
