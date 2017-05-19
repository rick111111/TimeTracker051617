using System;

namespace TimeTracker051617.Models
{
    public sealed class TimeSlice
    {
        public int Id { get; set; }
        public string DataSource { get; set; }
        public DateTime Start { get; set; }
        public TimeSpan Duration { get; set; }
        public string Category { get; set; }
        public string SubCategory { get; set; }
    }
}
