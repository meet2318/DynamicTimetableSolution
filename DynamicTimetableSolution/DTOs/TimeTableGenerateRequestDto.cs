using DynamicTimetableSolution.Models;

namespace DynamicTimetableSolution.DTOs
{
    public class TimeTableGenerateRequestDto
    {
        public TimeTableInput Input { get; set; } = new TimeTableInput();
        public List<Subject> Subjects { get; set; } = new List<Subject>();
    }
}