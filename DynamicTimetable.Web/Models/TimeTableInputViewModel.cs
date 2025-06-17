using System.ComponentModel.DataAnnotations;

namespace DynamicTimetable.Web.Models
{
    public class TimeTableInputViewModel
    {
        [Required(ErrorMessage = "Working Days is required")]
        [Range(1, 7, ErrorMessage = "Working Days must be between 1 and 7")]
        public int WorkingDays { get; set; }

        [Required(ErrorMessage = "Subjects per day is required")]
        [Range(1, 8, ErrorMessage = "Subjects per day must be between 1 and 8")]
        public int SubjectsPerDay { get; set; }

        [Required(ErrorMessage = "Total Subjects is required")]
        [Range(1, int.MaxValue, ErrorMessage = "Total Subjects must be at least 1")]
        public int TotalSubjects { get; set; }

        public int TotalHours => WorkingDays * SubjectsPerDay;
    }
}