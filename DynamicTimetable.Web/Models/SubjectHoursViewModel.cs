using System.ComponentModel.DataAnnotations;

namespace DynamicTimetable.Web.Models
{
    public class SubjectHoursViewModel
    {
        public string SubjectName { get; set; } = string.Empty;

        [Required]
        [Range(1, 100)]
        public int Hours { get; set; }
    }
}