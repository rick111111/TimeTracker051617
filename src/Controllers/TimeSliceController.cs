using Microsoft.AspNetCore.Mvc;
using TimeTracker051617.Models;

namespace TimeTracker051617.Controllers
{
    public class TimeSliceController : Controller
    {
        private ITimeSliceRepository repository;

        public TimeSliceController(ITimeSliceRepository repo)
        {
            repository = repo;
        }

        public ViewResult List() => View(repository.TimeSlices);
    }
}