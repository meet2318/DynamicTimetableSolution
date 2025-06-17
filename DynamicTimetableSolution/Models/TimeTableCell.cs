namespace DynamicTimetableSolution.Models
{
    public class TimeTableCell
    {
        public int Day { get; set; }
        public int Period { get; set; }
        public string SubjectName { get; set; } = string.Empty;
    }
}