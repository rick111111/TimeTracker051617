using Microsoft.AspNetCore.Mvc;
using TimeTracker051617.Models;
using System.Linq;

namespace TimeTracker051617.Controllers
{
    public class TimeSliceController : Controller
    {
        private ITimeSliceRepository repository;
        private const int PageSize = 4;

        public TimeSliceController(ITimeSliceRepository repo)
        {
            repository = repo;
        }

        public ViewResult List(int page = 1)
        {
            return View(repository.TimeSlices.Skip(PageSize * (page-1)).Take(PageSize));
        }
    }
}