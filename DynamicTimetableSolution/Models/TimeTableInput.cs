using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DynamicTimetableSolution.Models
{
    public class TimeTableInput
    {
        [Key]
        public int Id { get; set; }

        public int WorkingDays { get; set; }
        public int SubjectsPerDay { get; set; }
        public int TotalSubjects { get; set; }

        [NotMapped]
        public int TotalHours => WorkingDays * SubjectsPerDay;
    }
}