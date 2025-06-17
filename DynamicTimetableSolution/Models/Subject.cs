using System.ComponentModel.DataAnnotations;

namespace DynamicTimetableSolution.Models
{
    public class Subject
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int TotalHours { get; set; }
    }
}