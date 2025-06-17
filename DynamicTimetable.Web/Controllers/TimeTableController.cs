using DynamicTimetable.Web.Models;
using DynamicTimetable.Web.Services;
using Microsoft.AspNetCore.Mvc;

namespace DynamicTimetable.Web.Controllers
{
    public class TimeTableController : Controller
    {
        private readonly IApiClientService _apiClient;

        public TimeTableController(IApiClientService apiClient)
        {
            _apiClient = apiClient;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(new TimeTableInputViewModel());
        }

        [HttpPost]
        public IActionResult SubjectHours(TimeTableInputViewModel input)
        {
            int totalHours = input.WorkingDays * input.SubjectsPerDay;
            ViewBag.TotalHours = totalHours;
            ViewBag.TotalSubjects = input.TotalSubjects;
            ViewBag.InputData = input;

            var subjectList = new List<SubjectHoursViewModel>();
            for (int i = 0; i < input.TotalSubjects; i++)
            {
                subjectList.Add(new SubjectHoursViewModel { SubjectName = $"Subject {i + 1}" });
            }

            return View(subjectList);
        }

        [HttpPost]
        public async Task<IActionResult> Generate(TimeTableInputViewModel input, List<SubjectHoursViewModel> subjects)
        {
            var inserted = await _apiClient.AddSubjectsAsync(subjects);

            if (!inserted)
            {
                ModelState.AddModelError("", "Failed to insert subjects.");
                return View("SubjectHours", subjects);
            }

            var timetable = await _apiClient.GenerateTimeTableAsync(input, subjects);
            var model = new TimeTableResultViewModel { TimeTable = timetable };
            return View("Result", model);
        }
    }
}