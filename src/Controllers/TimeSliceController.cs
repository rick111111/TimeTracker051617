using Microsoft.AspNetCore.Mvc;
using TimeTracker051617.Models;
using System.Linq;
using TimeTracker051617.Models.ViewModels;

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
            TimeSliceListViewModel vm = new TimeSliceListViewModel()
            {
                TimeSlices = repository.TimeSlices.Skip(PageSize * (page - 1)).Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = PageSize,
                    TotalItems = repository.TimeSlices.Count()
                }
            };

            return View(vm);
        }
    }
}