using DynamicTimetableSolution.Models;

namespace DynamicTimetableSolution.Helpers
{
    public static class TimetableGenerator
    {
        public static List<List<string>> GenerateTimetable(int workingDays, int subjectsPerDay, List<Subject> subjects)
        {
            var totalHours = workingDays * subjectsPerDay;
            var subjectSlots = new List<string>();

            foreach (var subject in subjects)
            {
                for (int i = 0; i < subject.TotalHours; i++)
                {
                    subjectSlots.Add(subject.Name);
                }
            }

            var random = new Random();
            subjectSlots = subjectSlots.OrderBy(x => random.Next()).ToList();

            var timetable = new List<List<string>>();
            int index = 0;

            for (int i = 0; i < subjectsPerDay; i++)
            {
                var row = new List<string>();

                for (int j = 0; j < workingDays; j++)
                {
                    if (index < subjectSlots.Count)
                        row.Add(subjectSlots[index++]);
                    else
                        row.Add("");
                }

                timetable.Add(row);
            }

            return timetable;
        }
    }
}